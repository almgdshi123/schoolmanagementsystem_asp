using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class ParticipStudentActivService : IParticiStudentActivService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public ParticipStudentActivService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(ParticiStudentActivTb participStudentActiv)
        {
            await _repository.PartiStudentActivRepository.AddAsync(participStudentActiv);
            return "Success";
        }

        public async Task<string> DeleteAsync(ParticiStudentActivTb data)
        {
            var trans = _repository.PartiStudentActivRepository.BeginTransaction();
            try
            {

                await _repository.PartiStudentActivRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(ParticiStudentActivTb data)
        {
            await _repository.PartiStudentActivRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<ParticiStudentActivTb>> GetParticiStudentActivListAsync()
        {
            return await _repository.PartiStudentActivRepository.GetListAsync();
        }

        public async Task<ParticiStudentActivTb> GetByIDAsync(long id)
        {
            var entity = await _repository.PartiStudentActivRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.PartiStudentActivRepository.GetTableNoTracking().Where(predicate: x => x.DocmunetStatus.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}

