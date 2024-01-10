using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{

    public interface IBusService
    {
        Task<List<BusTb>> GetBusListAsync();
        Task<BusTb> GetByIDAsync(long id);
        Task<string> AddAsync(BusTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(BusTb data);
        Task<string> DeleteAsync(BusTb data);
    }

}
