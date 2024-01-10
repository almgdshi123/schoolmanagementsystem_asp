using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IClassDataService
    {
        public Task<List<ClassDataTb>> GetListAsync();
        public Task<ClassDataTb> GetClassDataTbByIDWithIncludeAsync(int id);
        public Task<ClassDataTb> GetByIDAsync(long id);
        public Task<string> AddAsync(ClassDataTb data);
        public Task<bool> IsNameArExist(string name);
        public Task<bool> IsNameExistExcludeSelf(string name, int id);
        public Task<string> EditAsync(ClassDataTb data);
        public Task<string> DeleteAsync(ClassDataTb data);
        public IQueryable<ClassDataTb> GetClassDataTbQuerable();
        public IQueryable<ClassDataTb> GetClassDataTbByDStageIDQuerable(int DID);
        //  public IQueryable<ClassDataTb> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search);
    }
}
