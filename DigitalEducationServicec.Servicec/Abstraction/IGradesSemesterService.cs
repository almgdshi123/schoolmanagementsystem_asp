using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IGradesSemesterService
    {
        public Task<List<GradesSemesterTb>> GetGradesSemesterListAsync();
        public Task<GradesSemesterTb> GetByIDAsync(long id);
        public Task<string> AddAsync(GradesSemesterTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(GradesSemesterTb data);
        public Task<string> DeleteAsync(GradesSemesterTb data);
    }
}
