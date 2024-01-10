using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IAAcademicStatusRepository : ICRUDRepository<AcademicStatusesTb> {

        public Task<List<AcademicStatusesTb>> GetAcademicStatusListAsync();
    }

}
