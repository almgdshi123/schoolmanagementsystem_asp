using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SectionDataService : ISectionDataService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public SectionDataService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion
        public async Task<string> AddAsync(SectionDataTb data)
        {
            await _repository.SectionDataRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(SectionDataTb data)
        {
            var trans = _repository.SectionDataRepository.BeginTransaction();
            try
            {

                await _repository.SectionDataRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SectionDataTb data)
        {
            await _repository.SectionDataRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<SectionDataTb> GetByIDAsync(long id)
        {
            var entity = await _repository.SectionDataRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<SectionDataTb>> GetSectionDataListAsync()
        {
            return await _repository.SectionDataRepository.GetTableNoTracking().Include(x => x.FileStudentTbs).ToListAsync();
        }

        public Task<bool> IsNameExist(string nameAr)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}
