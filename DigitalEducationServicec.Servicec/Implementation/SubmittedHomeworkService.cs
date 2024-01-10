using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{


    public class SubmittedHomeworkService : ISubmittedHomeworkService
    {
        public Task<string> AddAsync(SubmittedHomeworkTb data)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteAsync(SubmittedHomeworkTb data)
        {
            throw new NotImplementedException();
        }

        public Task<string> EditAsync(SubmittedHomeworkTb data)
        {
            throw new NotImplementedException();
        }

        public Task<SubmittedHomeworkTb> GetByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<List<SubmittedHomeworkTb>> GetSubmittedHomeworkListAsync()
        {
            throw new NotImplementedException();
        }

        public IQueryable<SubmittedHomeworkTb> GetSubmittedHomeworkQuerable()
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}
