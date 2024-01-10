using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class ParentService : IParentService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public ParentService(IUnitOfWork parentRepository)
        {
            _repository = parentRepository;
        }


        #endregion
        #region Handle Functions
        public async Task<List<ParentTb>> GetStudentsListAsync()
        {
            return await _repository.ParentRepository.GetParentListAsync();
        }

        public async Task<ParentTb> GetStudentByIDWithIncludeAsync(int id)
        {
            // var student = await _repository.GetByIdAsync(id);
            var student = await _repository.ParentRepository.GetByIdAsync(id);

            return student;
        }

        public async Task<string> AddAsync(ParentTb parent)
        {
            //Added Student
            await _repository.ParentRepository.AddAsync(parent);
            return "Success";
        }

        public async Task<bool> IsNameArExist(string nameAr)
        {
            //Check if the name is Exist Or not
            var student = _repository.ParentRepository.GetTableNoTracking().Where(x => x.ParentName.Equals(nameAr)).FirstOrDefault();
            if (student == null) return false;
            return true;
        }

        //public async Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        //{
        //    var student = await _repository.GetTableNoTracking().Where(x => x.ParentName.Equals(nameAr) & !x.ParentId.Equals(id)).FirstOrDefaultAsync();
        //    if (student == null) return false;
        //    return true;
        //    //Check if the name is Exist Or not
        //    var student = await _repository.GetTableNoTracking().Where(x => x.ParentName.Equals(nameAr) & !x.ParentId.Equals(id)).FirstOrDefaultAsync();
        //    if (student == null) return false;
        //    return true;
        //}

        public async Task<string> EditAsync(ParentTb student)
        {
            await _repository.ParentRepository.UpdateAsync(student);
            return "Success";
        }

        public async Task<string> DeleteAsync(ParentTb student)
        {
            var trans = _repository.ParentRepository.BeginTransaction();
            try
            {

                await _repository.ParentRepository.DeleteAsync(student);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }

        }

        public async Task<ParentTb> GetByIDAsync(long id)
        {
            var student = await _repository.ParentRepository.GetByIdAsync(id);
            return student;
        }

        public IQueryable<ParentTb> GetStudentsQuerable()
        {
            return _repository.ParentRepository.GetTableNoTracking().Include(x => x.ParentId).AsQueryable();
        }

        //public IQueryable<ParentTb> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search)
        //{
        //    var querable = _repository.GetTableNoTracking().Include(x => x.Department).AsQueryable();
        //    if (search != null)
        //    {
        //        querable = querable.Where(x => x.NameAr.Contains(search) || x.Address.Contains(search));
        //    }
        //    switch (orderingEnum)
        //    {
        //        case StudentOrderingEnum.StudID:
        //            querable = querable.OrderBy(x => x.StudID);
        //            break;
        //        case StudentOrderingEnum.Name:
        //            querable = querable.OrderBy(x => x.NameAr);
        //            break;
        //        case StudentOrderingEnum.Address:
        //            querable = querable.OrderBy(x => x.Address);
        //            break;
        //        case StudentOrderingEnum.DepartmentName:
        //            querable = querable.OrderBy(x => x.Department.DNameAr);
        //            break;
        //    }

        //    return querable;
        //}

        public async Task<bool> IsNameEnExist(string nameEn)
        {
            //Check if the name is Exist Or not
            var student = _repository.ParentRepository.GetTableNoTracking().Where(x => x.ParentName.Equals(nameEn)).FirstOrDefault();
            if (student == null) return false;
            return true;
        }

        public async Task<bool> IsNameEnExistExcludeSelf(string nameEn, int id)
        {
            //Check if the name is Exist Or not
            var student = await _repository.ParentRepository.GetTableNoTracking().Where(x => x.ParentName.Equals(nameEn) & !x.ParentId.Equals(id)).FirstOrDefaultAsync();
            if (student == null) return false;
            return true;
        }

        public IQueryable<ParentTb> GetStudentsByParentTbIDQuerable(int DID)
        {
            return _repository.ParentRepository.GetTableNoTracking().Where(x => x.ParentId.Equals(DID)).AsQueryable();
        }

        public async Task<List<ParentTb>> GetParentListAsync()
        {
            return await _repository.ParentRepository.GetParentListAsync();
        }

        public Task<ParentTb> GetParentByIDWithIncludeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsNameArExistExcludeSelf(string nameAr, int id)
        {
            throw new NotImplementedException();
        }
        #endregion




    }
}
