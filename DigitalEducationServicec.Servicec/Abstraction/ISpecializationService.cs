using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ISpecializationService
    {
        public Task<List<SpecializationTb>> GetSpecializationListAsync();
        public Task<SpecializationTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SpecializationTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(SpecializationTb data);
        public Task<string> DeleteAsync(SpecializationTb data);
    }
}
