using DigitalEducationServicec.Domain.Entity;


namespace DigitalEducationServicec.Servicec.Abstraction
{
    public interface IHomeworkService
    {
        public Task<List<HomeworkTb>> GetHomeworkListAsync();
        public Task<HomeworkTb> GetByIDAsync(long id);
        public Task<string> AddAsync(HomeworkTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(HomeworkTb data);
        public Task<string> DeleteAsync(HomeworkTb data);
    }
}
