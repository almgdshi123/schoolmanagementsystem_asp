using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IAcademicSystemService
    {
        public Task<List<AcademicSystemsTb>> GetAcademicSystemsListAsync();
        public Task<AcademicSystemsTb> GetByIDAsync(long id);
        public Task<string> AddAsync(AcademicSystemsTb academicSystems);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, int id);
        public Task<string> EditAsync(AcademicSystemsTb academicSystems);
        public Task<string> DeleteAsync(AcademicSystemsTb academicSystems);
    }
}
