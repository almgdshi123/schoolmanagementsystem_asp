using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class BusService : IBusService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public BusService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(BusTb bus)

        {
            await _repository.BusRepository.AddAsync(bus);
            return "Success";
        }

        public async Task<string> DeleteAsync(BusTb data)
        {
            var trans = _repository.BusRepository.BeginTransaction();
            try
            {

                await _repository.BusRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(BusTb data)
        {
            await _repository.BusRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<BusTb>> GetBusListAsync()
        {
            return await _repository.BusRepository.GetListAsync();
        }

        public async Task<BusTb> GetByIDAsync(long id)
        {
            var entity = await _repository.BusRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.BusRepository.GetTableNoTracking().Where(predicate: x => x.BusDriverName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}