using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IQualificationRepository : ICRUDRepository<QualificationTb>
    {
        public Task<List<QualificationTb>> GetListAsync();

    }

}
