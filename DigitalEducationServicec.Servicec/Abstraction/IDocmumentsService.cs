using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IDocmumentsService
    {
        public Task<List<DocmunetsTb>> GetDocmumentsListAsync();
        public Task<DocmunetsTb> GetByIDAsync(long id);
        public Task<string> AddAsync(DocmunetsTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(DocmunetsTb data);
        public Task<string> DeleteAsync(DocmunetsTb data);
    }

}
