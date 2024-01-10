using DigitalEducationServicec.Application.Features.Teacher.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Teacher
{
    public partial class TeacherProfile
    {

        public void EditTeacherCommandMapping()
        {
            CreateMap<EditTeacherCommand, TeacherTb>();

        }
    }
}
