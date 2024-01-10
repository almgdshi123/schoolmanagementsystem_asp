using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class StreetsService : IStreetsService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public StreetsService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(StreetsTb streets)
        {
            await _repository.StreetsRepository.AddAsync(streets);
            return "Success";
        }

        public async Task<string> DeleteAsync(StreetsTb data)
        {
            var trans = _repository.StreetsRepository.BeginTransaction();
            try
            {

                await _repository.StreetsRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(StreetsTb data)
        {
            await _repository.StreetsRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<StreetsTb> GetByIDAsync(int id)
        {
            var entity = await _repository.StreetsRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<StreetsTb>> GetStreetsListAsync()
        {
            return await _repository.StreetsRepository.GetListAsync();
        }


        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.StreetsRepository.GetTableNoTracking().Where(predicate: x => x.StreetName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }



        public Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            throw new NotImplementedException();
        }
    }
}