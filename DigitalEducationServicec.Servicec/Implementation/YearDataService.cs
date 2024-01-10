using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class YearDataService : IYearDataService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public YearDataService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion

        public async Task<string> AddAsync(YearDataTb data)
        {
            await _repository.YearDataRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(YearDataTb data)
        {
            var trans = _repository.YearDataRepository.BeginTransaction();
            try
            {

                await _repository.YearDataRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(YearDataTb data)
        {
            await _repository.YearDataRepository.UpdateAsync(data);
            return "Success";
        }

        public Task<YearDataTb> GetByIDAsync(long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<YearDataTb>> GetYearDataListAsync()
        {
            return await _repository.YearDataRepository.GetAllListAsyN();
        }

        public IQueryable<YearDataTb> GetYearDataQuerable()
        {
            return _repository.YearDataRepository.GetTableNoTracking().AsQueryable();
        }

        public Task<bool> IsNameExist(string name)
        {
            throw new NotImplementedException();
        }
    }

}
