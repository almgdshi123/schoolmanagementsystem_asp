using DigitalEducationServicec.Application.Features.Semesters.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Semester
{
    public partial class SemesterProfile
    {
        public void GetSemesterByIDMapping()
        {
            CreateMap<SemesterTb, GetSemesterListResponse>();

        }

    }
}
