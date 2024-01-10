using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.SchoolGroup
{
    public partial class SchoolGroupProfile : Profile
    {
        public SchoolGroupProfile()
        {
            GetSchoolGroupListMapping();
            GetSchoolGroupByIDMapping();
            AddSchoolGroupCommandMapping();
            EditSchoolGroupCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
