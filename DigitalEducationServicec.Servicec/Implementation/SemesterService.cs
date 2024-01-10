
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class SemesterService : ISemesterService
    {
        private readonly IUnitOfWork _repository;



        public SemesterService(IUnitOfWork repository)
        {
            _repository = repository;

        }



        public async Task<string> AddAsync(SemesterTb entity)
        {
            await _repository.SemesterRepository.AddAsync(entity);
            return "Success";
        }


        public async Task<string> DeleteAsync(SemesterTb data)
        {
            var trans = _repository.SemesterRepository.BeginTransaction();
            try
            {

                await _repository.SemesterRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(SemesterTb data)
        {
            await _repository.SemesterRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<IEnumerable<SemesterTb>> GetAll()
        {
            var semesters = _repository.SemesterRepository.GetTableAsTracking();
            return await Task.FromResult(semesters.ToList());
        }


        public async Task<SemesterTb> GetByIDAsync(long id)
        {
            var entity = await _repository.SemesterRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<List<SemesterTb>> GetSemesterListAsync()
        {
            return await _repository.SemesterRepository.GetTableNoTracking().Include(x => x.SemesterAcademicTbs).ToListAsync();
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

