using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class DayDataService : IDayDataService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public DayDataService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(DayDataTb dayData)
        {
            await _repository.DayDataRepository.AddAsync(dayData);
            return "Success";
        }

        public async Task<string> DeleteAsync(DayDataTb data)
        {
            var trans = _repository.DayDataRepository.BeginTransaction();
            try
            {

                await _repository.DayDataRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(DayDataTb data)
        {
            await _repository.DayDataRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<DayDataTb>> GetDayDataListAsync()
        {
            return await _repository.DayDataRepository.GetListAsync();
        }

        public async Task<DayDataTb> GetByIDAsync(long id)
        {
            var entity = await _repository.DayDataRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.DayDataRepository.GetTableNoTracking().Where(predicate: x => x.DayName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}

