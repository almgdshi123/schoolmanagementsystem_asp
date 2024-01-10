using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface IAcademicDiscountRepository : ICRUDRepository<AcademicDiscountTb>
    {

        public Task<List<AcademicDiscountTb>> GetListAsync();
    }

}

