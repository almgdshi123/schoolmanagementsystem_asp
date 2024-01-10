using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class StudentActivityService : IStudentActivitieService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public StudentActivityService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(StudentActivitieTb studentActivities)
        {
            await _repository.StudentActivitieRepository.AddAsync(studentActivities);
            return "Success";
        }

        public async Task<string> DeleteAsync(StudentActivitieTb data)
        {
            var trans = _repository.StudentActivitieRepository.BeginTransaction();
            try
            {

                await _repository.StudentActivitieRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(StudentActivitieTb data)
        {
            await _repository.StudentActivitieRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<StudentActivitieTb>> GetStudentActivitieListAsync()
        {
            return await _repository.StudentActivitieRepository.GetListAsync();
        }


        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.StudentActivitieRepository.GetTableNoTracking().Where(predicate: x => x.StudentActivitieName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }



        public async Task<StudentActivitieTb> GetByIDAsync(long id)
        {
            var entity = await _repository.StudentActivitieRepository.GetByIdAsync(id);

            return entity;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            throw new NotImplementedException();
        }
    }
}

