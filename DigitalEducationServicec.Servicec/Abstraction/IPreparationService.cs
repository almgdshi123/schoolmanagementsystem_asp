using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IPreparationService
    {
        public Task<List<PreparationTb>> GetPreparationListAsync();
        public Task<PreparationTb> GetByIDAsync(long id);
        public Task<string> AddAsync(PreparationTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(PreparationTb data);
        public Task<string> DeleteAsync(PreparationTb data);
    }
}
