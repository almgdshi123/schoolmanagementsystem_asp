using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class MonthAcademicService : IMonthAcademicService
    {

        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public MonthAcademicService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(MonthAcademicTb data)
        {
            await _repository.MonthAcademicRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(MonthAcademicTb data)
        {

            var trans = _repository.MonthAcademicRepository.BeginTransaction();
            try
            {

                await _repository.MonthAcademicRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(MonthAcademicTb data)
        {
            await _repository.MonthAcademicRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<MonthAcademicTb> GetByIDAsync(long id)
        {
            var entity = await _repository.MonthAcademicRepository.GetByIdAsync(id);

            return entity;
        }





        public async Task<List<MonthAcademicTb>> GetMonthAcademicListAsync()
        {
            return await _repository.MonthAcademicRepository.GetAllListAsyN();
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
