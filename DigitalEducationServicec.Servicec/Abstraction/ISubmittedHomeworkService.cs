using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ISubmittedHomeworkService
    {
        public Task<List<SubmittedHomeworkTb>> GetSubmittedHomeworkListAsync();
        public Task<SubmittedHomeworkTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SubmittedHomeworkTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(SubmittedHomeworkTb data);
        public Task<string> DeleteAsync(SubmittedHomeworkTb data);
        public IQueryable<SubmittedHomeworkTb> GetSubmittedHomeworkQuerable();
    }
}
