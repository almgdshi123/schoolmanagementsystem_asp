using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IStudentActivitieRepository : ICRUDRepository<StudentActivitieTb>
    {

        public Task<List<StudentActivitieTb>> GetListAsync();
    }

}