using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface ITuitionFeeInstallmentRepository : ICRUDRepository<TuitionFeeInstallmentTb>
    {

        public Task<List<TuitionFeeInstallmentTb>> GetListAsync();
    }

}