using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{


    public interface IDocmunetStudentService
    {
        Task<List<DocmunetStudentTb>> GetDocmunetStudentListAsync();
        Task<DocmunetStudentTb> GetByIDAsync(long id);
        Task<string> AddAsync(DocmunetStudentTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(DocmunetStudentTb data);
        Task<string> DeleteAsync(DocmunetStudentTb data);
    }

}