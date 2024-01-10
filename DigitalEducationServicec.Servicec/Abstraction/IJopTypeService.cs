using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IJopTypeService
    {
        Task<List<JopTypeTb>> GetJopTypeListAsync();
        Task<JopTypeTb> GetByIDAsync(long id);
        Task<string> AddAsync(JopTypeTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(JopTypeTb data);
        Task<string> DeleteAsync(JopTypeTb data);
    }
}