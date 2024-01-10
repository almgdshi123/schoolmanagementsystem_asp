using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SchoolGroupService : ISchoolGroupService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public SchoolGroupService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion

        public async Task<string> AddAsync(SchoolGroupTb data)
        {
            await _repository.SchoolGroupRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(SchoolGroupTb data)
        {
            var trans = _repository.SchoolGroupRepository.BeginTransaction();
            try
            {

                await _repository.SchoolGroupRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SchoolGroupTb data)
        {
            await _repository.SchoolGroupRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<SchoolGroupTb> GetByIDAsync(long id)
        {
            var entity = await _repository.SchoolGroupRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<SchoolGroupTb>> GetSchoolGroupListAsync()
        {
            return await _repository.SchoolGroupRepository.GetTableNoTracking().Include(x => x.SchoolTbs).ToListAsync();
        }

        public IQueryable<SchoolGroupTb> GetSchoolGroupQuerable()
        {
            return _repository.SchoolGroupRepository.GetTableNoTracking().Include(x => x.SchoolTbs);
        }

        public Task<bool> IsNameExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}
