using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class AcademicStatusService : IAcademicStatusService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public AcademicStatusService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(AcademicStatusesTb academicStatuses)
        {
            await _repository.AcademicStatusesRepository.AddAsync(academicStatuses);
            return "Success";
        }

        public async Task<string> DeleteAsync(AcademicStatusesTb data)
        {
            var trans = _repository.AcademicStatusesRepository.BeginTransaction();
            try
            {

                await _repository.AcademicStatusesRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(AcademicStatusesTb data)
        {
            await _repository.AcademicStatusesRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<AcademicStatusesTb>> GetAcademicStatusesListAsync()
        {
            return await _repository.AcademicStatusesRepository.GetAcademicStatusListAsync();
        }

        public async Task<AcademicStatusesTb> GetByIDAsync(long id)
        {
            var entity = await _repository.AcademicStatusesRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.AcademicStatusesRepository.GetTableNoTracking().Where(predicate: x => x.StatusName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
