using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class InstallmentService : IInstallmentService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public InstallmentService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(InstallmentTb installment)
        {
            await _repository.InstallmentRepository.AddAsync(installment);
            return "Success";
        }

        public async Task<string> DeleteAsync(InstallmentTb data)
        {
            var trans = _repository.InstallmentRepository.BeginTransaction();
            try
            {

                await _repository.InstallmentRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(InstallmentTb data)
        {
            await _repository.InstallmentRepository.UpdateAsync(data);
            return "Success";
        }





        public async Task<InstallmentTb> GetByIDAsync(long id)
        {
            var entity = await _repository.InstallmentRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.InstallmentRepository.GetTableNoTracking().Where(predicate: x => x.InstallmentName.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<InstallmentTb>> GetInstallmentListAsync()
        {
            return await _repository.InstallmentRepository.GetListAsync();
        }
    }
}

