using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IDistributionOfBuseStreetService
    {
        public Task<List<DistributionOfBuseStreetTb>> GetDistributionOfBuseStreetListAsync();
        public Task<DistributionOfBuseStreetTb> GetByIDAsync(long id);
        public Task<string> AddAsync(DistributionOfBuseStreetTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(DistributionOfBuseStreetTb data);
        public Task<string> DeleteAsync(DistributionOfBuseStreetTb data);
    }
}