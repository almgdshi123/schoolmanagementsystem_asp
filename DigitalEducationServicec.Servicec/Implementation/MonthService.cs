using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class MonthService : IMonthService
    {

        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public MonthService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(MonthTb data)
        {
            await _repository.MonthRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(MonthTb data)
        {

            var trans = _repository.MonthRepository.BeginTransaction();
            try
            {

                await _repository.MonthRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(MonthTb data)
        {
            await _repository.MonthRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<MonthTb> GetByIDAsync(long id)
        {
            var entity = await _repository.MonthRepository.GetByIdAsync(id);

            return entity;
        }



        public async Task<List<MonthTb>> GetMonthListAsync()
        {
            return await _repository.MonthRepository.GetAllListAsyN();
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
