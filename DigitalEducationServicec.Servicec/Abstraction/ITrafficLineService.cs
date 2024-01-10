using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ITrafficLineService
    {
        Task<List<TrafficLineTb>> GetTrafficLineListAsync();
        Task<TrafficLineTb> GetByIDAsync(long id);
        Task<string> AddAsync(TrafficLineTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(TrafficLineTb data);
        Task<string> DeleteAsync(TrafficLineTb data);
    }
}