using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class TypesDiscountsService : ITypesDiscountsService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public TypesDiscountsService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(TypesDiscountsTb typesDiscounts)
        {
            await _repository.TypesDiscountsRepository.AddAsync(typesDiscounts);
            return "Success";
        }

        public async Task<string> DeleteAsync(TypesDiscountsTb data)
        {
            var trans = _repository.TypesDiscountsRepository.BeginTransaction();
            try
            {

                await _repository.TypesDiscountsRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(TypesDiscountsTb data)
        {
            await _repository.TypesDiscountsRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<TypesDiscountsTb>> GetTypesDiscountsListAsync()
        {
            return await _repository.TypesDiscountsRepository.GetListAsync();
        }

        public async Task<TypesDiscountsTb> GetByIDAsync(long id)
        {
            var entity = await _repository.TypesDiscountsRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.TypesDiscountsRepository.GetTableNoTracking().Where(predicate: x => x.TypesDiscountName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}

