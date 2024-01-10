using DigitalEducationServicec.Application.Features.Student.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Students
{
    public partial class StudentProfile
    {
        public void AddStudentCommandMapping()
        {

            CreateMap<AddStudentCommand, StudentTb>();
        }
    }
}
