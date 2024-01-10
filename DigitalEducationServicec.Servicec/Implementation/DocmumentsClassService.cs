using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class DocmumentsClassService : IDocmumentsClassService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public DocmumentsClassService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(DocmunetsClassTb docmumentsClass)
        {
            await _repository.DocmunetsClassRepository.AddAsync(docmumentsClass);
            return "Success";
        }

        public async Task<string> DeleteAsync(DocmunetsClassTb data)
        {
            var trans = _repository.DocmunetsClassRepository.BeginTransaction();
            try
            {

                await _repository.DocmunetsClassRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(DocmunetsClassTb data)
        {
            await _repository.DocmunetsClassRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<DocmunetsClassTb>> GetDocmumentsClassListAsync()
        {
            return await _repository.DocmunetsClassRepository.GetListAsync();
        }

        public async Task<DocmunetsClassTb> GetByIDAsync(long id)
        {
            var entity = await _repository.DocmunetsClassRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.DocmunetsClassRepository.GetTableNoTracking().Where(predicate: x => x.DocmunetName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }
}

