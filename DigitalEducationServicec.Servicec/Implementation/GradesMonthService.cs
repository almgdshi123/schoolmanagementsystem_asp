using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class GradesMonthService : IGradesMonthService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public GradesMonthService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(GradesMonthTb data)
        {
            await _repository.GradesMonthRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(GradesMonthTb data)
        {

            var trans = _repository.GradesMonthRepository.BeginTransaction();
            try
            {

                await _repository.GradesMonthRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(GradesMonthTb data)
        {
            await _repository.GradesMonthRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<GradesMonthTb> GetByIDAsync(long id)
        {
            var entity = await _repository.GradesMonthRepository.GetByIdAsync(id);

            return entity;
        }
        public async Task<List<GradesMonthTb>> GetGradesMonthListAsync()
        {
            return await _repository.GradesMonthRepository.GetAllListAsyN();
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
