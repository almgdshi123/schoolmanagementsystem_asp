using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IInstallmentService
    {
        Task<List<InstallmentTb>> GetInstallmentListAsync();
        Task<InstallmentTb> GetByIDAsync(long id);
        Task<string> AddAsync(InstallmentTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(InstallmentTb data);
        Task<string> DeleteAsync(InstallmentTb data);
    }

}
