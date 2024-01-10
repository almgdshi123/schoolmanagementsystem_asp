using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class StageService : IStageService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public StageService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion
        public async Task<string> AddAsync(StageTb data)
        {
            await _repository.StageRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(StageTb data)
        {
            var trans = _repository.StageRepository.BeginTransaction();
            try
            {

                await _repository.StageRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(StageTb data)
        {
            await _repository.StageRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<StageTb> GetByIDAsync(long id)
        {
            var entity = await _repository.StageRepository.GetByIdAsync(id);

            return entity;
        }

        public IQueryable<StageTb> GetClassDataTbQuerable()
        {
            return _repository.StageRepository.GetTableNoTracking().Include(x => x.ClassDataTbs);

        }

        public async Task<List<StageTb>> GetStageTbListAsync()
        {
            return await _repository.StageRepository.GetTableNoTracking().Include(x => x.ClassDataTbs).ToListAsync();

        }
        public async Task<bool> IsNameExist(string name)
        {

            //Check if the name is Exist Or not
            var entity = _repository.StageRepository.GetTableNoTracking().Where(x => x.StageName.Equals(name)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }
    }
}
