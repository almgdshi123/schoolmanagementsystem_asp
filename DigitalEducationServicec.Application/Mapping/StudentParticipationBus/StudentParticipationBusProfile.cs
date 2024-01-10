using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.StudentParticipationBus
{
    public partial class StudentParticipationBusProfile : Profile
    {
        public StudentParticipationBusProfile()
        {
            GetStudentParticipationBusListMapping();
            GetStudentParticipationBusByIDMapping();
            AddStudentParticipationBusCommandMapping();
            EditStudentParticipationBusCommandMapping();
        }
    }




}
