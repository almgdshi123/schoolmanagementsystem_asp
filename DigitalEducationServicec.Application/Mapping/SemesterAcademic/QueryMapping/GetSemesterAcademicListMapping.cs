using DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SemesterAcademic
{
    public partial class SemesterAcademicProfile

    {
        public void GetSemesterAcademicListMapping()
        {
            CreateMap<SemesterAcademicTb, GetSemesterAcademicListResponse>();

        }


    }
}
