using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class AcademicSystemService : IAcademicSystemService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public AcademicSystemService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion
        public async Task<string> AddAsync(AcademicSystemsTb academicSystems)
        {
            await _repository.AcademicSystemsRepository.AddAsync(academicSystems);
            return "Success";
        }

        public async Task<string> DeleteAsync(AcademicSystemsTb data)
        {
            var trans = _repository.AcademicSystemsRepository.BeginTransaction();
            try
            {

                await _repository.AcademicSystemsRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(AcademicSystemsTb data)
        {
            await _repository.AcademicSystemsRepository.UpdateAsync(data);
            return "Success";
        }


        public async Task<List<AcademicSystemsTb>> GetAcademicSystemsListAsync()
        {
            return await _repository.AcademicSystemsRepository.GetListAsync();
        }

        public async Task<AcademicSystemsTb> GetByIDAsync(long id)
        {
            var entity = await _repository.AcademicSystemsRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {

            //Check if the name is Exist Or not
            var entity = _repository.AcademicSystemsRepository.GetTableNoTracking().Where(x => x.SystemName.Equals(name)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, int id)
        {
            throw new NotImplementedException();
        }
    }
}
