using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISubmittedHomeworkRepository : ICRUDRepository<SubmittedHomeworkTb>
    {
        public Task<List<SubmittedHomeworkTb>> GetListAsync();

    }

}
