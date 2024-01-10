using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class GradesSemesterService : IGradesSemesterService
    {

        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public GradesSemesterService(IUnitOfWork repository)
        {
            _repository = repository;
        }
        #endregion


        public async Task<string> AddAsync(GradesSemesterTb data)
        {
            await _repository.GradesSemesterRepository.AddAsync(data);
            return "Success";
        }

        public async Task<string> DeleteAsync(GradesSemesterTb data)
        {

            var trans = _repository.GradesSemesterRepository.BeginTransaction();
            try
            {

                await _repository.GradesSemesterRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(GradesSemesterTb data)
        {
            await _repository.GradesSemesterRepository.UpdateAsync(data);
            return "Success";
        }

        public async Task<GradesSemesterTb> GetByIDAsync(long id)
        {
            var entity = await _repository.GradesSemesterRepository.GetByIdAsync(id);

            return entity;
        }








        public async Task<List<GradesSemesterTb>> GetGradesSemesterListAsync()
        {
            return await _repository.GradesSemesterRepository.GetAllListAsyN();
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
