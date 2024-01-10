using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IDistributionSubTeacherService
    {
        public Task<List<DistributionSubTeacherTb>> GetDistributionSubTeacherListAsync();
        public Task<DistributionSubTeacherTb> GetByIDAsync(long id);
        public Task<string> AddAsync(DistributionSubTeacherTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(DistributionSubTeacherTb data);
        public Task<string> DeleteAsync(DistributionSubTeacherTb data);
    }
}
