using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ITuitionFeeInstallmentService
    {
        public Task<List<TuitionFeeInstallmentTb>> GetTuitionFeeInstallmentListAsync();
        public Task<TuitionFeeInstallmentTb> GetByIDAsync(long id);
        public Task<string> AddAsync(TuitionFeeInstallmentTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(TuitionFeeInstallmentTb data);
        public Task<string> DeleteAsync(TuitionFeeInstallmentTb data);
    }
}