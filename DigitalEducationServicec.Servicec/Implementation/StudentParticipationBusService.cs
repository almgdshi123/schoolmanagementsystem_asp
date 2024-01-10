using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using DigitalEducationServicec.Servicec.Abstraction;

namespace DigitalEducationServicec.Servicec.Implementation
{
    public class StudentParticipationBusService : IStudentParticipationBusService
    {
        #region Fields
        private readonly IUnitOfWork _repository;
        #endregion

        #region constructors
        public StudentParticipationBusService(IUnitOfWork repository)
        {
            _repository = repository;
        }


        #endregion

        public async Task<string> AddAsync(StudentParticipationBusTb studentParticipationBus)
        {
            await _repository.StudentParticipationBusRepository.AddAsync(studentParticipationBus);
            return "Success";
        }

        public async Task<string> DeleteAsync(StudentParticipationBusTb data)
        {
            var trans = _repository.StudentParticipationBusRepository.BeginTransaction();
            try
            {

                await _repository.StudentParticipationBusRepository.DeleteAsync(data);
                await trans.CommitAsync();
                return "Success";
            }
            catch
            {
                await trans.RollbackAsync();
                return "Falied";
            }
        }

        public async Task<string> EditAsync(StudentParticipationBusTb data)
        {
            await _repository.StudentParticipationBusRepository.UpdateAsync(data);
            return "Success";
        }



        public async Task<List<StudentParticipationBusTb>> GetStudentParticipationBusListAsync()
        {
            return await _repository.StudentParticipationBusRepository.GetListAsync();
        }

        public async Task<StudentParticipationBusTb> GetByIDAsync(long id)
        {
            var entity = await _repository.StudentParticipationBusRepository.GetByIdAsync(id);

            return entity;
        }

        public async Task<bool> IsNameExist(string name)
        {
            //Check if the name is Exist Or not
            var entity = _repository.StudentParticipationBusRepository.GetTableNoTracking().Where(predicate: x => x.ParticipationType.Equals(name, StringComparison.Ordinal)).FirstOrDefault();
            if (entity == null) return false;
            return true;
        }

        public Task<bool> IsNameExistExcludeSelf(string name, long id)
        {
            throw new NotImplementedException();
        }
    }


}
