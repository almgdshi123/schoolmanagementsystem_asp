using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Abstracts
{
    public interface ITypeOfActivitiesRepository : ICRUDRepository<TypeOfActivitiesTb>
    {

        public Task<List<TypeOfActivitiesTb>> GetListAsync();
    }

}