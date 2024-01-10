using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{


    public interface ISubjectService
    {
        public Task<List<SubjectTb>> GetSubjectListAsync();
        public Task<SubjectTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SubjectTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(SubjectTb data);
        public Task<string> DeleteAsync(SubjectTb data);
        public IQueryable<SubjectTb> GetSubjectQuerable();
    }
}
