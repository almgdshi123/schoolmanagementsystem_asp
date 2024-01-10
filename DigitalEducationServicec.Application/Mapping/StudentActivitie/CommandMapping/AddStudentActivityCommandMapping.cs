using DigitalEducationServicec.Application.Features.StudentActivitie.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.StudentActivitie
{
    public partial class StudentActivityProfile
    {
        public void AddStudentActivityCommandMapping()
        {
            CreateMap<AddStudentActivitieCommand, StudentActivitieTb>();
        }
    }

}
