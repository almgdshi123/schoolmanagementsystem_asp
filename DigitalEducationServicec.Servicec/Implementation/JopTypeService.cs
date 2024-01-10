using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class JopTypeService : IJopTypeService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public JopTypeService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(JopTypeTb jopTypes)
        {
            await _repository.JopTypeRepository.AddAsync(jopTypes);
            return "Success";
        }

        public async Task<string> DeleteAsync(JopTypeTb data)
        {
            var trans = _repository.JopTypeRepository.BeginTransaction();
            try
            {

                await _repository.JopTypeRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(JopTypeTb data)
        {
            await _repository.JopTypeRepository.UpdateAsync(data);
            return "Success";
        }





        public async Task<JopTypeTb> GetByIDAsync(long id)
        {
            var entity = await _repository.JopTypeRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.JopTypeRepository.GetTableNoTracking().Where(predicate: x => x.JopTypeName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<JopTypeTb>> GetJopTypeListAsync()
        {
            return await _repository.JopTypeRepository.GetListAsync();
        }
    }

}