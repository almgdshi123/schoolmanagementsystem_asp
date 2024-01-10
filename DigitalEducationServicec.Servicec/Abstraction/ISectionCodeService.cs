using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{


    public interface ISectionCodeService
    {
        public Task<List<SectionCodeTb>> GetSectionCodeListAsync();
        public Task<SectionCodeTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SectionCodeTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(SectionCodeTb data);
        public Task<string> DeleteAsync(SectionCodeTb data);
    }
}