using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IAcademicStatusService
    {
        public Task<List<AcademicStatusesTb>> GetAcademicStatusesListAsync();
        public Task<AcademicStatusesTb> GetByIDAsync(long id);
        public Task<string> AddAsync(AcademicStatusesTb academicStatuses);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(AcademicStatusesTb academicStatuses);
        public Task<string> DeleteAsync(AcademicStatusesTb academicStatuses);
    }
}
