using DigitalEducationServicec.Application.Features.StudentParticipationBus.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.StudentParticipationBus
{
    public partial class StudentParticipationBusProfile
    {
        public void AddStudentParticipationBusCommandMapping()
        {
            CreateMap<AddStudentParticipationBusCommand, StudentParticipationBusTb>();
        }
    }

}
