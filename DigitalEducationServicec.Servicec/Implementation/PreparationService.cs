using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class PreparationService : IPreparationService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public PreparationService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(PreparationTb data)
        {
            await _repository.PreparationRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(PreparationTb data)
        {

            var trans = _repository.PreparationRepository.BeginTransaction();
            try
            {

                await _repository.PreparationRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(PreparationTb data)
        {
            await _repository.PreparationRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<PreparationTb> GetByIDAsync(long id)
        {
            var entity = await _repository.PreparationRepository.GetByIdAsync(id);

            return entity;
        }


        public async Task<List<PreparationTb>> GetPreparationListAsync()
        {
            return await _repository.PreparationRepository.GetAllListAsyN();
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
