using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ISchoolService
    {
        public Task<List<SchoolTb>> GetSchooListAsync();
        public Task<SchoolTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SchoolTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(SchoolTb data);
        public Task<string> DeleteAsync(SchoolTb data);
        public IQueryable<SchoolTb> GetSchoolaQuerable();
    }
}