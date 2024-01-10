using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IVacationsService
    {
        Task<List<VacationsTb>> GetVacationsListAsync();
        Task<VacationsTb> GetByIDAsync(long id);
        Task<string> AddAsync(VacationsTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(VacationsTb data);
        Task<string> DeleteAsync(VacationsTb data);
    }
}