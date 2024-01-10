using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.GradesSemester
{
    public partial class GradesSemesterProfile : Profile
    {
        public GradesSemesterProfile()
        {
            GetGradesSemesterListMapping();
            GetGradesSemesterByIDMapping();
            AddGradesSemesterCommandMapping();
            EditGradesSemesterCommandMapping();
        }
    }
}
