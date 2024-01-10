using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class FinesService : IFinesService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public FinesService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(FinesTb fines)
        {
            await _repository.FinesRepository.AddAsync(fines);
            return "Success";
        }

        public async Task<string> DeleteAsync(FinesTb data)
        {
            var trans = _repository.FinesRepository.BeginTransaction();
            try
            {

                await _repository.FinesRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(FinesTb data)
        {
            await _repository.FinesRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<FinesTb>> GetFinesListAsync()
        {
            return await _repository.FinesRepository.GetListAsync();
        }

        public async Task<FinesTb> GetByIDAsync(long id)
        {
            var entity = await _repository.FinesRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.FinesRepository.GetTableNoTracking().Where(predicate: x => x.FinesName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}

