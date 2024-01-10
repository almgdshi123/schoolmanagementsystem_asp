using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{




    // IAppreciationService interface
    public interface IAppreciationService
    {
        Task<List<AppreciationTb>> GetAppreciationListAsync();
        Task<AppreciationTb> GetByIDAsync(long id);
        Task<string> AddAsync(AppreciationTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(AppreciationTb data);
        Task<string> DeleteAsync(AppreciationTb data);
    }
}