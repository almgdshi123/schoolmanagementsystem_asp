using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class TuitionFeeInstallmentService : ITuitionFeeInstallmentService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public TuitionFeeInstallmentService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(TuitionFeeInstallmentTb tuitionFeeInstallments)
        {
            await _repository.TuitionFeeInstallmentRepository.AddAsync(tuitionFeeInstallments);
            return "Success";
        }

        public async Task<string> DeleteAsync(TuitionFeeInstallmentTb data)
        {
            var trans = _repository.TuitionFeeInstallmentRepository.BeginTransaction();
            try
            {

                await _repository.TuitionFeeInstallmentRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(TuitionFeeInstallmentTb data)
        {
            await _repository.TuitionFeeInstallmentRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<TuitionFeeInstallmentTb>> GetTuitionFeeInstallmentListAsync()
        {
            return await _repository.TuitionFeeInstallmentRepository.GetListAsync();
        }

        public async Task<TuitionFeeInstallmentTb> GetByIDAsync(long id)
        {
            var entity = await _repository.TuitionFeeInstallmentRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.TuitionFeeInstallmentRepository.GetTableNoTracking().Where(predicate: x => x.TuitionFeeInstallmentName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}