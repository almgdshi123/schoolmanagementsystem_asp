using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IStudentParticipationBusService
    {
        Task<List<StudentParticipationBusTb>> GetStudentParticipationBusListAsync();
        Task<StudentParticipationBusTb> GetByIDAsync(long id);
        Task<string> AddAsync(StudentParticipationBusTb data);
        Task<bool> IsNameExist(string nameAr);
        Task<bool> IsNameExistExcludeSelf(string name, long id);
        Task<string> EditAsync(StudentParticipationBusTb data);
        Task<string> DeleteAsync(StudentParticipationBusTb data);
    }

}