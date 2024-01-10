using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class ClassTuitionFeesService : IClassTuitionFeesService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public ClassTuitionFeesService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(ClassTuitionFeesTb classTuitionFees)
        {
            await _repository.ClassTuitionFeesRepository.AddAsync(classTuitionFees);
            return "Success";
        }

        public async Task<string> DeleteAsync(ClassTuitionFeesTb data)
        {
            var trans = _repository.ClassTuitionFeesRepository.BeginTransaction();
            try
            {

                await _repository.ClassTuitionFeesRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(ClassTuitionFeesTb data)
        {
            await _repository.ClassTuitionFeesRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<ClassTuitionFeesTb>> GetClassTuitionFeesListAsync()
        {
            return await _repository.ClassTuitionFeesRepository.GetListAsync();
        }

        public async Task<ClassTuitionFeesTb> GetByIDAsync(long id)
        {
            var entity = await _repository.ClassTuitionFeesRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.ClassTuitionFeesRepository.GetTableNoTracking().Where(predicate: x => x.ClassTuitionFeesName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }


}
