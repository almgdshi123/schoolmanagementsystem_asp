using DigitalEducationServicec.Application.Features.Grades.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Grades
{
    public partial class GradesProfile
    {
        public void GetGradesListMapping()
        {
            CreateMap<GradesTb, GetGradesListResponse>();

        }


    }
}
