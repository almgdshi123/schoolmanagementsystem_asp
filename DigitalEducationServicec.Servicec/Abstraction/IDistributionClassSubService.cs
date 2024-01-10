using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IDistributionClassSubService
    {
        public Task<List<DistributionClassSubTb>> GeDistributionClassSubListAsync();
        public Task<DistributionClassSubTb> GetByIDAsync(long id);
        public Task<string> AddAsync(DistributionClassSubTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(DistributionClassSubTb data);
        public Task<string> DeleteAsync(DistributionClassSubTb data);
    }
}
