using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class AcademicDiscountService : IAcademicDiscountService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public AcademicDiscountService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(AcademicDiscountTb academicDiscounts)
        {
            await _repository.AcademicDiscountRepository.AddAsync(academicDiscounts);
            return "Success";
        }

        public async Task<string> DeleteAsync(AcademicDiscountTb data)
        {
            var trans = _repository.AcademicDiscountRepository.BeginTransaction();
            try
            {

                await _repository.AcademicDiscountRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(AcademicDiscountTb data)
        {
            await _repository.AcademicDiscountRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<AcademicDiscountTb>> GetAcademicDiscountListAsync()
        {
            return await _repository.AcademicDiscountRepository.GetListAsync();
        }

        public async Task<AcademicDiscountTb> GetByIDAsync(long id)
        {
            var entity = await _repository.AcademicDiscountRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.AcademicDiscountRepository.GetTableNoTracking().Where(predicate: x => x.AcademicDiscountName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}


