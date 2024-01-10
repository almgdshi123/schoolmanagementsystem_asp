using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class DistributionOfBusesStreetService : IDistributionOfBuseStreetService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public DistributionOfBusesStreetService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(DistributionOfBuseStreetTb distributionOfBusesStreet)
        {
            await _repository.DistributionOfBuseStreetRepository.AddAsync(distributionOfBusesStreet);
            return "Success";
        }

        public async Task<string> DeleteAsync(DistributionOfBuseStreetTb data)
        {
            var trans = _repository.DistributionOfBuseStreetRepository.BeginTransaction();
            try
            {

                await _repository.DistributionOfBuseStreetRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(DistributionOfBuseStreetTb data)
        {
            await _repository.DistributionOfBuseStreetRepository.UpdateAsync(data);
            return "Success";
        }




        public async Task<DistributionOfBuseStreetTb> GetByIDAsync(long id)
        {
            var entity = await _repository.DistributionOfBuseStreetRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.DistributionOfBuseStreetRepository.GetTableNoTracking().Where(predicate: x => x.Bus.BusDriverName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DistributionOfBuseStreetTb>> GetDistributionOfBuseStreetListAsync()
        {
            return await _repository.DistributionOfBuseStreetRepository.GetListAsync();
        }
    }

}