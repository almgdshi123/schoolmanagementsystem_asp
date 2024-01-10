using DigitalEducationServicec.Application.Features.Student.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentPaginationMapping()
        {
            CreateMap<StudentTb, GetStudentPaginatedListResponse>();
        }
    }
}