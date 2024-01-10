using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.DistributionSubTeacher
{
    public partial class DistributionSubTeacherProfile : Profile
    {
        public DistributionSubTeacherProfile()
        {
            GetDistributionSubTeacherListMapping();
            GetDistributionSubTeacherByIDMapping();
            AddDistributionSubTeacherCommandMapping();
            EditDistributionSubTeacherCommandMapping();
            //    GetStudentPaginationMapping();
        }
    }
}
