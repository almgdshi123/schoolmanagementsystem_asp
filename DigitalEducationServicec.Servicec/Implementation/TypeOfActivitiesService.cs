using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class TypeOfActivitiesService : ITypeOfActivitiesService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public TypeOfActivitiesService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(TypeOfActivitiesTb typeOfActivities)
        {
            await _repository.TypeOfActivitiesRepository.AddAsync(typeOfActivities);
            return "Success";
        }

        public async Task<string> DeleteAsync(TypeOfActivitiesTb data)
        {
            var trans = _repository.TypeOfActivitiesRepository.BeginTransaction();
            try
            {

                await _repository.TypeOfActivitiesRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(TypeOfActivitiesTb data)
        {
            await _repository.TypeOfActivitiesRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<TypeOfActivitiesTb>> GetTypeOfActivitiesListAsync()
        {
            return await _repository.TypeOfActivitiesRepository.GetListAsync();
        }

        public async Task<TypeOfActivitiesTb> GetByIDAsync(long id)
        {
            var entity = await _repository.TypeOfActivitiesRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.TypeOfActivitiesRepository.GetTableNoTracking().Where(predicate: x => x.TypeOfActivitieName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }

}