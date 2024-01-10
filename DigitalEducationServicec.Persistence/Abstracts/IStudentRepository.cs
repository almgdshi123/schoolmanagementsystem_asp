using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IStudentRepository : ICRUDRepository<StudentTb>
    {
        public Task<List<StudentTb>> GetListAsync();

    }

}
