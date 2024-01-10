
using DigitalEducationServicec.Domain.Entity;



namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IAcademicSystemsRepository : ICRUDRepository<AcademicSystemsTb> {

        public Task<List<AcademicSystemsTb>> GetListAsync();
    }

}
