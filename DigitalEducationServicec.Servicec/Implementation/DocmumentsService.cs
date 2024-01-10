using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class DocmumentsService : IDocmumentsService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public DocmumentsService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(DocmunetsTb docmuments)
        {
            await _repository.DocmunetsRepository.AddAsync(docmuments);
            return "Success";
        }

        public async Task<string> DeleteAsync(DocmunetsTb data)
        {
            var trans = _repository.DocmunetsRepository.BeginTransaction();
            try
            {

                await _repository.DocmunetsRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(DocmunetsTb data)
        {
            await _repository.DocmunetsRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<DocmunetsTb>> GetDocmumentsListAsync()
        {
            return await _repository.DocmunetsRepository.GetListAsync();
        }

        public async Task<DocmunetsTb> GetByIDAsync(long id)
        {
            var entity = await _repository.DocmunetsRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.DocmunetsRepository.GetTableNoTracking().Where(predicate: x => x.DocmunetName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}

