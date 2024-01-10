using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ISectionDataService
    {
        public Task<List<SectionDataTb>> GetSectionDataListAsync();
        public Task<SectionDataTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SectionDataTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(SectionDataTb data);
        public Task<string> DeleteAsync(SectionDataTb data);
    }
}
