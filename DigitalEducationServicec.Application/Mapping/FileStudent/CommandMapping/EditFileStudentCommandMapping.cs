using DigitalEducationServicec.Application.Features.FileStudent.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.FileStudent
{
    public partial class FileStudentProfile
    {
        public void EditFileStudentCommandMapping()
        {
            CreateMap<EditFileStudentCommand, FileStudentTb>();

        }
    }
}
