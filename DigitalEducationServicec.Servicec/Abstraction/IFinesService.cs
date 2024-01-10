using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IFinesService
    {
        Task<List<FinesTb>> GetFinesListAsync();
        Task<FinesTb> GetByIDAsync(long id);
        Task<string> AddAsync(FinesTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(FinesTb data);
        Task<string> DeleteAsync(FinesTb data);
    }
}
