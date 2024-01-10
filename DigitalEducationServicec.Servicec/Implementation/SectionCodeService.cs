using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SectionCodeService : ISectionCodeService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public SectionCodeService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(SectionCodeTb sectionCode)
        {
            await _repository.SectionCodeRepository.AddAsync(sectionCode);
            return "Success";
        }

        public async Task<string> DeleteAsync(SectionCodeTb data)
        {
            var trans = _repository.SectionCodeRepository.BeginTransaction();
            try
            {

                await _repository.SectionCodeRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SectionCodeTb data)
        {
            await _repository.SectionCodeRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<SectionCodeTb>> GetSectionCodeListAsync()
        {
            return await _repository.SectionCodeRepository.GetListAsync();
        }

        public async Task<SectionCodeTb> GetByIDAsync(long id)
        {
            var entity = await _repository.SectionCodeRepository.GetByIdAsync(id);

            return entity;
        }




        public async Task<bool> IsNameExist(string nameAr)
        {
            var entity = _repository.SectionCodeRepository.GetTableNoTracking().Where(predicate: x => x.SectionCodeName.Equals(nameAr, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }

}
