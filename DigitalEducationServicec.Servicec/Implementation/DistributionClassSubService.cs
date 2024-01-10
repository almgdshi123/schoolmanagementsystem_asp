using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class DistributionClassSubService : IDistributionClassSubService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public DistributionClassSubService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(DistributionClassSubTb data)
        {
            await _repository.DistributionClassSubRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(DistributionClassSubTb data)
        {

            var trans = _repository.DistributionClassSubRepository.BeginTransaction();
            try
            {

                await _repository.DistributionClassSubRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(DistributionClassSubTb data)
        {
            await _repository.DistributionClassSubRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<DistributionClassSubTb> GetByIDAsync(long id)
        {
            var entity = await _repository.DistributionClassSubRepository.GetByIdAsync(id);

            return entity;
        }


        public async Task<List<DistributionClassSubTb>> GeDistributionClassSubListAsync()
        {
            return await _repository.DistributionClassSubRepository.GetAllListAsyN();
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
