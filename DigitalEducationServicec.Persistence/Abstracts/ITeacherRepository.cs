using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ITeacherRepository : ICRUDRepository<TeacherTb>
    {
        public Task<List<TeacherTb>> GetListAsync();

    }
}


