using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.ParticiStudentActiv
{
    public partial class PartiStudentActivProfile : Profile
    {
        public PartiStudentActivProfile()
        {
            GetPartiStudentActivListMapping();
            GetPartiStudentActivByIDMapping();
            AddPartiStudentActivCommandMapping();
            EditPartiStudentActivCommandMapping();
        }
    }






}
