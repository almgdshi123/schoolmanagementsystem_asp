using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IClassTuitionFeesService
    {
        Task<List<ClassTuitionFeesTb>> GetClassTuitionFeesListAsync();
        Task<ClassTuitionFeesTb> GetByIDAsync(long id);
        Task<string> AddAsync(ClassTuitionFeesTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(ClassTuitionFeesTb data);
        Task<string> DeleteAsync(ClassTuitionFeesTb data);
    }
}