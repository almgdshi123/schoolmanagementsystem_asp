using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IHomeworkRepository : ICRUDRepository<HomeworkTb>
    {
        public Task<List<HomeworkTb>> GetListAsync();

    }

}
