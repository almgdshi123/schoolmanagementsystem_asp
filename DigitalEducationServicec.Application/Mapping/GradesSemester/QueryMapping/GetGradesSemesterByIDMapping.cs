using DigitalEducationServicec.Application.Features.GradesSemester.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.GradesSemester
{
    public partial class GradesSemesterProfile
    {
        public void GetGradesSemesterByIDMapping()
        {
            CreateMap<GradesSemesterTb, GetGradesSemesterListResponse>();

        }


    }
}
