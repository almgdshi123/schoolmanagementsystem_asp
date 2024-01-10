using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IQualificationService
    {
        public Task<List<QualificationTb>> GetQualificationListAsync();
        public Task<QualificationTb> GetByIDAsync(long id);
        public Task<string> AddAsync(QualificationTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(QualificationTb data);
        public Task<string> DeleteAsync(QualificationTb data);
    }
}
