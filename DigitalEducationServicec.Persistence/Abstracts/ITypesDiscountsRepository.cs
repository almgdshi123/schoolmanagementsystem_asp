using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface ITypesDiscountsRepository : ICRUDRepository<TypesDiscountsTb>
    {

        public Task<List<TypesDiscountsTb>> GetListAsync();
    }

}
