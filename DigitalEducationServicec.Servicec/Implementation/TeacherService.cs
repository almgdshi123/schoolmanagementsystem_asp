using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class TeacherService : ITeacherService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public TeacherService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion
        public async Task<string> AddAsync(TeacherTb data)
        {
            await _repository.TeacherRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(TeacherTb data)
        {
            var trans = _repository.TeacherRepository.BeginTransaction();
            try
            {

                await _repository.TeacherRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(TeacherTb data)
        {
            await _repository.TeacherRepository.UpdateAsync(data);
            return "Success";
        }

        public Task<TeacherTb> GetByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<TeacherTb> GeTeacherTbTbByIDWithIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TeacherTb> GetTeacherByParentTbIDQuerable(int DID)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TeacherTb> GetTeacherQuerable()
        {
            throw new NotImplementedException();
        }

        public async Task<List<TeacherTb>> GetTeacherTbTbListAsync()
        {
            return await _repository.TeacherRepository.GetAllListAsyN();
        }

        public Task<bool> IsNameArExist(string nameAr)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameEnExist(string nameEn)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
        {
            throw new NotImplementedException();
        }
    }
}
