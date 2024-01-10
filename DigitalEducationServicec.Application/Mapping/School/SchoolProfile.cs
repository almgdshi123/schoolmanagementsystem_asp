using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.School
{
    public partial class SchoolProfile : Profile
    {
        public SchoolProfile()
        {
            GetSchoolListMapping();
            GetSchoolByIDMapping();
            AddSchoolCommandMapping();
            EditSchoolCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
