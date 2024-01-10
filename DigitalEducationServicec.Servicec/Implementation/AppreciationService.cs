using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class AppreciationService : IAppreciationService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public AppreciationService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(AppreciationTb appreciation)
        {
            await _repository.AppreciationRepository.AddAsync(appreciation);
            return "Success";
        }

        public async Task<string> DeleteAsync(AppreciationTb data)
        {
            var trans = _repository.AppreciationRepository.BeginTransaction();
            try
            {

                await _repository.AppreciationRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(AppreciationTb data)
        {
            await _repository.AppreciationRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<AppreciationTb>> GetAppreciationListAsync()
        {
            return await _repository.AppreciationRepository.GetListAsync();
        }

        public async Task<AppreciationTb> GetByIDAsync(long id)
        {
            var entity = await _repository.AppreciationRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.AppreciationRepository.GetTableNoTracking().Where(predicate: x => x.AppreciationName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
