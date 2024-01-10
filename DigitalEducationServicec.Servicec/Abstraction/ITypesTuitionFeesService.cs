using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ITypesTuitionFeesService
    {
        Task<List<TypesTuitionFeesTb>> GetTypesTuitionFeesListAsync();
        Task<TypesTuitionFeesTb> GetByIDAsync(long id);
        Task<string> AddAsync(TypesTuitionFeesTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(TypesTuitionFeesTb data);
        Task<string> DeleteAsync(TypesTuitionFeesTb data);
    }

}