using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class TypesTuitionFeesService : ITypesTuitionFeesService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public TypesTuitionFeesService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(TypesTuitionFeesTb typesTuitionFees)
        {
            await _repository.TypesTuitionFeesRepository.AddAsync(typesTuitionFees);
            return "Success";
        }

        public async Task<string> DeleteAsync(TypesTuitionFeesTb data)
        {
            var trans = _repository.TypesTuitionFeesRepository.BeginTransaction();
            try
            {

                await _repository.TypesTuitionFeesRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(TypesTuitionFeesTb data)
        {
            await _repository.TypesTuitionFeesRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<TypesTuitionFeesTb>> GetTypesTuitionFeesListAsync()
        {
            return await _repository.TypesTuitionFeesRepository.GetListAsync();
        }

        public async Task<TypesTuitionFeesTb> GetByIDAsync(long id)
        {
            var entity = await _repository.TypesTuitionFeesRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.TypesTuitionFeesRepository.GetTableNoTracking().Where(predicate: x => x.TypesTuitionFeesName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }

}