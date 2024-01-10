using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IInstallmentRepository : ICRUDRepository<InstallmentTb>
    {

        public Task<List<InstallmentTb>> GetListAsync();
    }

}

