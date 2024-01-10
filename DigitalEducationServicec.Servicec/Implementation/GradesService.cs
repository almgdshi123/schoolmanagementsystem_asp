using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class GradesService : IGradesService
    {


        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public GradesService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion
        public async Task<string> AddAsync(GradesTb data)
        {
            await _repository.GradesRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(GradesTb data)
        {
            var trans = _repository.GradesRepository.BeginTransaction();
            try
            {

                await _repository.GradesRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(GradesTb data)
        {
            await _repository.GradesRepository.UpdateAsync(data);
            return "Success";
        }

        public Task<ClassDataTb> GetByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<GradesTb> GetGradesTbQuerable()
        {
            return _repository.GradesRepository.GetTableNoTracking().Include(x => x.GradesSemesterTbs).AsQueryable();
        }

        public async Task<List<GradesTb>> GetListAsync()
        {
            return await _repository.GradesRepository.GetListAsync();
        }

        public Task<bool> IsNameArExist(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            throw new NotImplementedException();
        }
        public async Task<GradesTb> GetByIDAsyncs(long id)
        {
            var entity = await _repository.GradesRepository.GetByIdAsync(id);

            return entity;
        }



    }
}
