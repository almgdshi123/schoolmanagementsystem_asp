using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IFileStudentRepository : ICRUDRepository<FileStudentTb>
    {

        public Task<List<FileStudentTb>> GetListAsync();
    }

}
