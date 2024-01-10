using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class FileStudentService : IFileStudentService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public FileStudentService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(FileStudentTb data)
        {
            await _repository.FileStudentRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(FileStudentTb data)
        {

            var trans = _repository.FileStudentRepository.BeginTransaction();
            try
            {

                await _repository.FileStudentRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(FileStudentTb data)
        {
            await _repository.FileStudentRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<FileStudentTb> GetByIDAsync(long id)
        {
            var entity = await _repository.FileStudentRepository.GetByIdAsync(id);

            return entity;
        }



        public async Task<List<FileStudentTb>> GetFileStudentListAsync()
        {
            return await _repository.FileStudentRepository.GetAllListAsyN();
        }

        public Task<bool> IsNameExist(string nameAr)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
