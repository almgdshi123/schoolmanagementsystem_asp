using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IStudentActivitieService
    {
        public Task<List<StudentActivitieTb>> GetStudentActivitieListAsync();
        public Task<StudentActivitieTb> GetByIDAsync(long id);
        public Task<string> AddAsync(StudentActivitieTb data);
        public Task<bool> IsNameExist(string name);
        public Task<bool> IsNameExistExcludeSelf(string name, int id);
        public Task<string> EditAsync(StudentActivitieTb data);
        public Task<string> DeleteAsync(StudentActivitieTb data);
    }



}
