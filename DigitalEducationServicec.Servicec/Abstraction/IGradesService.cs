using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IGradesService
    {
        public Task<List<GradesTb>> GetListAsync();
        public Task<GradesTb> GetByIDAsyncs(long id);

        public Task<string> AddAsync(GradesTb data);
        public Task<bool> IsNameArExist(string name);
        public Task<bool> IsNameExistExcludeSelf(string name, int id);
        public Task<string> EditAsync(GradesTb data);
        public Task<string> DeleteAsync(GradesTb data);
        public IQueryable<GradesTb> GetGradesTbQuerable();
    }
}
