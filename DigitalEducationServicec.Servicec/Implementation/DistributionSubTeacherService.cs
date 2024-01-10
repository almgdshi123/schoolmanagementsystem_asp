using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class DistributionSubTeacherService : IDistributionSubTeacherService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public DistributionSubTeacherService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(DistributionSubTeacherTb data)
        {
            await _repository.DistributionSubTeacherRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(DistributionSubTeacherTb data)
        {

            var trans = _repository.DistributionSubTeacherRepository.BeginTransaction();
            try
            {

                await _repository.DistributionSubTeacherRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(DistributionSubTeacherTb data)
        {
            await _repository.DistributionSubTeacherRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<DistributionSubTeacherTb> GetByIDAsync(long id)
        {
            var entity = await _repository.DistributionSubTeacherRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<DistributionSubTeacherTb>> GetDistributionSubTeacherListAsync()
        {
            return await _repository.DistributionSubTeacherRepository.GetAllListAsyN();
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
