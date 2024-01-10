using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SchoolService : ISchoolService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public SchoolService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(SchoolTb data)
        {

            await _repository.SchoolRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(SchoolTb data)
        {
            var trans = _repository.SchoolRepository.BeginTransaction();
            try
            {

                await _repository.SchoolRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SchoolTb data)
        {
            await _repository.SchoolRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<SchoolTb> GetByIDAsync(long id)
        {
            var entity = await _repository.SchoolRepository.GetByIdAsync(id);

            return entity;
        }

        public IQueryable<SchoolTb> GetSchoolaQuerable()
        {
            return _repository.SchoolRepository.GetTableNoTracking().Include(x => x.SchoolGroup);
        }

        public async Task<List<SchoolTb>> GetSchooListAsync()
        {
            return await _repository.SchoolRepository.GetTableNoTracking().Include(x => x.SchoolGroup).ToListAsync();
        }

        public Task<bool> IsNameExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}
