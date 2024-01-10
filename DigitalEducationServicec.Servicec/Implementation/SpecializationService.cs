using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SpecializationService : ISpecializationService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public SpecializationService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion

        public async Task<string> AddAsync(SpecializationTb data)
        {
            await _repository.SpecializationRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(SpecializationTb data)
        {
            var trans = _repository.SpecializationRepository.BeginTransaction();
            try
            {

                await _repository.SpecializationRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SpecializationTb data)
        {
            await _repository.SpecializationRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<SpecializationTb> GetByIDAsync(long id)
        {
            var entity = await _repository.SpecializationRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<SpecializationTb>> GetSpecializationListAsync()
        {
            return await _repository.SpecializationRepository.GetTableNoTracking().Include(x => x.TeacherTbs).ToListAsync();
        }

        public Task<bool> IsNameExist(string nameAr)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
