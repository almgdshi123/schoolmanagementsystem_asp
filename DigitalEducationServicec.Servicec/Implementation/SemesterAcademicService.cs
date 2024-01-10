using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SemesterAcademicService : ISemesterAcademicService
    {
        private readonly IUnitOfWork _repository;



        public SemesterAcademicService(IUnitOfWork repository)
        {
            _repository = repository;

        }


        public async Task<string> AddAsync(SemesterAcademicTb data)
        {
            await _repository.SemesterAcademicRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(SemesterAcademicTb data)
        {
            var trans = _repository.SemesterAcademicRepository.BeginTransaction();
            try
            {

                await _repository.SemesterAcademicRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SemesterAcademicTb data)
        {
            await _repository.SemesterAcademicRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<SemesterAcademicTb> GetByIDAsync(long id)
        {
            var entity = await _repository.SemesterAcademicRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<SemesterAcademicTb>> GetSectionDataListAsync()
        {
            throw new NotImplementedException();
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
