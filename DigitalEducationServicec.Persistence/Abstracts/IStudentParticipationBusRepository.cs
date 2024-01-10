using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IStudentParticipationBusRepository : ICRUDRepository<StudentParticipationBusTb>
    {

        public Task<List<StudentParticipationBusTb>> GetListAsync();
    }

}