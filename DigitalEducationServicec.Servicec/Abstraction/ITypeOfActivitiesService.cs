using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Servicec.Abstraction
{




    public interface ITypeOfActivitiesService
    {
        public Task<List<TypeOfActivitiesTb>> GetTypeOfActivitiesListAsync();
        public Task<TypeOfActivitiesTb> GetByIDAsync(long id);
        public Task<string> AddAsync(TypeOfActivitiesTb data);
        public Task<bool> IsNameExist(string nameAr);
        public Task<bool> IsNameExistExcludeSelf(string name, long id);
        public Task<string> EditAsync(TypeOfActivitiesTb data);
        public Task<string> DeleteAsync(TypeOfActivitiesTb data);
    }
}
