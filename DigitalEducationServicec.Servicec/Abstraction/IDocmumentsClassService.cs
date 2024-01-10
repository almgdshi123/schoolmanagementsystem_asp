using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{

    public interface IDocmumentsClassService
    {
        public Task<List<DocmunetsClassTb>> GetDocmumentsClassListAsync();
        public Task<DocmunetsClassTb> GetByIDAsync(long id);
        public Task<string> AddAsync(DocmunetsClassTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(DocmunetsClassTb data);
        public Task<string> DeleteAsync(DocmunetsClassTb data);
    }
}