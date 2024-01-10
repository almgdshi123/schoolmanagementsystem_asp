using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Domain.Helpers;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class StudentService : IStudentService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public StudentService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion
        public async Task<string> AddAsync(StudentTb data)
        {
            //Added Student
            await _repository.StudentRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(StudentTb data)
        {
            var trans = _repository.StudentRepository.BeginTransaction();
            try
            {

                await _repository.StudentRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(StudentTb data)
        {
            await _repository.StudentRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<StudentTb> GetByIDAsync(long id)
        {
            var data = await _repository.StudentRepository.GetByIdAsync(id);
            return data;
        }

        public IQueryable<StudentTb> GetStudentsByParentTbIDQuerable(int DID)
        {
            return _repository.StudentRepository.GetTableNoTracking().Include(x => x.StudentId).AsQueryable();
        }

        public IQueryable<StudentTb> GetStudentsQuerable()
        {
            return _repository.StudentRepository.GetTableNoTracking().Include(x => x.StudentId).AsQueryable();
        }

        public Task<StudentTb> GetStudentTbByIDWithIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<StudentTb>> GetStudentTbListAsync()
        {
            var data = await _repository.StudentRepository.GetAllListAsyN();
            return data;
        }

        public Task<bool> IsNameArExist(string nameAr)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameEnExist(string nameEn)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
        {
            throw new NotImplementedException();
        }

        IQueryable<StudentTb> IStudentService.FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search)
        {
            var querable = _repository.StudentRepository.GetTableNoTracking().AsQueryable();
            if (search != null)
            {
                querable = querable.Where(x => x.FullNameArabic.Contains(search) || x.Address.Contains(search));
            }
            switch (orderingEnum)
            {
                case StudentOrderingEnum.StudentId:
                    querable = querable.OrderBy(x => x.StudentId);
                    break;
                case StudentOrderingEnum.FullNameArabic:
                    querable = querable.OrderBy(x => x.FullNameArabic);
                    break;
                case StudentOrderingEnum.Address:
                    querable = querable.OrderBy(x => x.Address);
                    break;

            }

            return querable;
        }
    }
}
