using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface ISchoolGroupService
    {
        public Task<List<SchoolGroupTb>> GetSchoolGroupListAsync();
        public Task<SchoolGroupTb> GetByIDAsync(long id);
        public Task<string> AddAsync(SchoolGroupTb data);
        public Task<bool> IsNameExist(string name);
        public Task<string> EditAsync(SchoolGroupTb data);
        public Task<string> DeleteAsync(SchoolGroupTb data);
        public IQueryable<SchoolGroupTb> GetSchoolGroupQuerable();
    }
}
