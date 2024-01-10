using DigitalEducationServicec.Application.Features.Student.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentByIDMapping()
        {
            CreateMap<StudentTb, GetSingleStudentResponse>();

        }


    }
}
