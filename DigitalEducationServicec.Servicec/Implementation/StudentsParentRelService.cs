using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class StudentsParentRelService : IStudentsParentRelService
    {
        public Task<string> AddAsync(StudentsParentRelTb data)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(StudentsParentRelTb data)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditAsync(StudentsParentRelTb data)
        {
            throw new NotImplementedException();
        }

        public Task<StudentsParentRelTb> GetByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<StudentsParentRelTb>> GetStudentsParentRelListAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<StudentsParentRelTb> GetSubjectQuerable()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}
