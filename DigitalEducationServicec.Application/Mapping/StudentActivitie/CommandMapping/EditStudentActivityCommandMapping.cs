using DigitalEducationServicec.Application.Features.StudentActivitie.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.StudentActivitie
{
    public partial class StudentActivityProfile
    {
        public void EditStudentActivityCommandMapping()
        {
            CreateMap<EditStudentActivitieCommand, StudentActivitieTb>();
        }
    }
}
