using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class HomeworkService : IHomeworkService
    {

        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public HomeworkService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(HomeworkTb data)
        {
            await _repository.HomeworkRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(HomeworkTb data)
        {

            var trans = _repository.HomeworkRepository.BeginTransaction();
            try
            {

                await _repository.HomeworkRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(HomeworkTb data)
        {
            await _repository.HomeworkRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<HomeworkTb> GetByIDAsync(long id)
        {
            var entity = await _repository.HomeworkRepository.GetByIdAsync(id);

            return entity;
        }





        public async Task<List<HomeworkTb>> GetHomeworkListAsync()
        {
            return await _repository.HomeworkRepository.GetAllListAsyN();
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
