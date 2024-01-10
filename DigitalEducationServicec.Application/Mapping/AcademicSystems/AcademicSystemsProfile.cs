using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.AcademicSystems
{
    public partial class AcademicSystemsProfile : Profile
    {
        public AcademicSystemsProfile()
        {
            GetAcademicSystemsListMapping();
            GetAcademicSystemsByIDMapping();
            AddAcademicSystemsCommandMapping();
            EditAcademicSystemsCommandMapping();
            //  GetStudentPaginationMapping();
        }
    }
}
