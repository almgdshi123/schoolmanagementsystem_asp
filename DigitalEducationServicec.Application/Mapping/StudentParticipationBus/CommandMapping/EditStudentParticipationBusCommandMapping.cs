using DigitalEducationServicec.Application.Features.StudentParticipationBus.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.StudentParticipationBus
{
    public partial class StudentParticipationBusProfile
    {
        public void EditStudentParticipationBusCommandMapping()
        {
            CreateMap<EditStudentParticipationBusCommand, StudentParticipationBusTb>();
        }
    }

}
