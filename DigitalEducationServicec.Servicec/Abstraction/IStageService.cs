using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IStageService
    {
        public Task<List<StageTb>> GetStageTbListAsync();
        public Task<StageTb> GetByIDAsync(long id);
        public Task<string> AddAsync(StageTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(StageTb data);
        public Task<string> DeleteAsync(StageTb data);
        public IQueryable<StageTb> GetClassDataTbQuerable();

    }
}
