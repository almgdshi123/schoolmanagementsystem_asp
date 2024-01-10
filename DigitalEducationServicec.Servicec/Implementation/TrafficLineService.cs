using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class TrafficLineService : ITrafficLineService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public TrafficLineService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(TrafficLineTb trafficLine)
        {
            await _repository.TrafficLineRepository.AddAsync(trafficLine);
            return "Success";
        }

        public async Task<string> DeleteAsync(TrafficLineTb data)
        {
            var trans = _repository.TrafficLineRepository.BeginTransaction();
            try
            {

                await _repository.TrafficLineRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(TrafficLineTb data)
        {
            await _repository.TrafficLineRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<TrafficLineTb>> GetTrafficLineListAsync()
        {
            return await _repository.TrafficLineRepository.GetListAsync();
        }

        public async Task<TrafficLineTb> GetByIDAsync(long id)
        {
            var entity = await _repository.TrafficLineRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.TrafficLineRepository.GetTableNoTracking().Where(predicate: x => x.TrafficLineName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}

