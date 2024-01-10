using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class VacationsService : IVacationsService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public VacationsService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(VacationsTb vacations)
        {
            await _repository.VacationsRepository.AddAsync(vacations);
            return "Success";
        }

        public async Task<string> DeleteAsync(VacationsTb data)
        {
            var trans = _repository.VacationsRepository.BeginTransaction();
            try
            {

                await _repository.VacationsRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(VacationsTb data)
        {
            await _repository.VacationsRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<VacationsTb>> GetVacationsListAsync()
        {
            return await _repository.VacationsRepository.GetListAsync();
        }

        public async Task<VacationsTb> GetByIDAsync(long id)
        {
            var entity = await _repository.VacationsRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.VacationsRepository.GetTableNoTracking().Where(predicate: x => x.VacationName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }

}
