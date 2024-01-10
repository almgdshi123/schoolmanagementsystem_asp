using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SubjectService : ISubjectService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public SubjectService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion
        public async Task<string> AddAsync(SubjectTb data)
        {
            await _repository.SubjectRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(SubjectTb data)
        {
            var trans = _repository.SubjectRepository.BeginTransaction();
            try
            {

                await _repository.SubjectRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SubjectTb data)
        {
            await _repository.SubjectRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<SubjectTb> GetByIDAsync(long id)
        {
            var data = await _repository.SubjectRepository.GetByIdAsync(id);
            return data;
        }

        public async Task<List<SubjectTb>> GetSubjectListAsync()
        {
            return await _repository.SubjectRepository.GetAllListAsyN();
        }

        public IQueryable<SubjectTb> GetSubjectQuerable()
        {
            return _repository.SubjectRepository.GetTableNoTracking().AsQueryable();
        }

        public Task<bool> IsNameExist(string name)
        {
            throw new NotImplementedException();
        }
    }
}
