using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.AcademicStatuses
{
    public partial class AcademicStatusesProfile : Profile
    {
        public AcademicStatusesProfile()
        {
            GetAcademicStatusesListMapping();
            GetAcademicStatusesByIDMapping();
            AddAcademicStatusesCommandMapping();
            EditAcademicStatusesCommandMapping();
            //GetStudentPaginationMapping();
        }
    }
}
