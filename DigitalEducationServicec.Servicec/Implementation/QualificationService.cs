using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class QualificationService : IQualificationService
    {

        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public QualificationService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(QualificationTb data)
        {
            await _repository.QualificationRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(QualificationTb data)
        {

            var trans = _repository.QualificationRepository.BeginTransaction();
            try
            {

                await _repository.QualificationRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(QualificationTb data)
        {
            await _repository.QualificationRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<QualificationTb> GetByIDAsync(long id)
        {
            var entity = await _repository.QualificationRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<QualificationTb>> GetQualificationListAsync()
        {
            return await _repository.QualificationRepository.GetAllListAsyN();
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
