
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IGradesRepository : ICRUDRepository<GradesTb>
    {

        public Task<List<GradesTb>> GetListAsync();
    }

}






