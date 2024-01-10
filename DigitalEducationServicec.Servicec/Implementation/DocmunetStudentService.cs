using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class DocumentStudentService : IDocmunetStudentService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public DocumentStudentService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(DocmunetStudentTb documentStudent)
        {
            await _repository.DocmunetStudentRepository.AddAsync(documentStudent);
            return "Success";
        }

        public async Task<string> DeleteAsync(DocmunetStudentTb data)
        {
            var trans = _repository.DocmunetStudentRepository.BeginTransaction();
            try
            {

                await _repository.DocmunetStudentRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(DocmunetStudentTb data)
        {
            await _repository.DocmunetStudentRepository.UpdateAsync(data);
            return "Success";
        }





        public async Task<DocmunetStudentTb> GetByIDAsync(long id)
        {
            var entity = await _repository.DocmunetStudentRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.DocmunetStudentRepository.GetTableNoTracking().Where(predicate: x => x.DocmunetType.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<DocmunetStudentTb>> GetDocmunetStudentListAsync()
        {
            return await _repository.DocmunetStudentRepository.GetListAsync();
        }
    }


}
