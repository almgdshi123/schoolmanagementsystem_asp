using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class ClassDataService : IClassDataService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public ClassDataService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion

        public async Task<string> AddAsync(ClassDataTb data)
        {
            await _repository.ClassDataRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(ClassDataTb data)
        {

            var trans = _repository.ClassDataRepository.BeginTransaction();
            try
            {

                await _repository.ClassDataRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(ClassDataTb data)
        {
            await _repository.ClassDataRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<ClassDataTb> GetByIDAsync(long id)
        {
            var entity = await _repository.ClassDataRepository.GetByIdAsync(id);

            return entity;
        }

        public IQueryable<ClassDataTb> GetClassDataTbByDStageIDQuerable(int DID)
        {
            return _repository.ClassDataRepository.GetTableNoTracking().Where(x => x.StageId.Equals(DID)).AsQueryable();
        }

        public async Task<ClassDataTb> GetClassDataTbByIDWithIncludeAsync(int id)
        {
            var data = _repository.ClassDataRepository.GetTableNoTracking()
                                         .Include(x => x.Stage)
                                         .Where(x => x.ClassId.Equals(id))
                                         .FirstOrDefault();
            return data;
        }

        public IQueryable<ClassDataTb> GetClassDataTbQuerable()
        {
            return _repository.ClassDataRepository.GetTableNoTracking().Include(x => x.Stage).AsQueryable();
        }

        public async Task<List<ClassDataTb>> GetListAsync()
        {
            return await _repository.ClassDataRepository.GetListAsync();
        }

        public async Task<bool> IsNameArExist(string name)
        {

            //Check if the name is Exist Or not
            var entity = _repository.ClassDataRepository.GetTableNoTracking().Where(x => x.ClassName.Equals(name)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            throw new NotImplementedException();
        }
    }
}