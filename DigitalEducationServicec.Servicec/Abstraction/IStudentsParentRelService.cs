using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IStudentsParentRelService
    {
        public Task<List<StudentsParentRelTb>> GetStudentsParentRelListAsync();
        public Task<StudentsParentRelTb> GetByIDAsync(long id);
        public Task<string> AddAsync(StudentsParentRelTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(StudentsParentRelTb data);
        public Task<string> DeleteAsync(StudentsParentRelTb data);
        public IQueryable<StudentsParentRelTb> GetSubjectQuerable();
    }
}
