using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface ISectionDataRepository : ICRUDRepository<SectionDataTb>
    {
        public Task<List<SectionDataTb>> GetListAsync();

    }

}
