using DigitalEducationServicec.Application.Features.DocmunetStudent.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DocmunetStudent
{
    public partial class DocmunetStudentProfile
    {
        public void EditDocmunetStudentCommandMapping()
        {
            CreateMap<EditDocmunetStudentCommand, DocmunetStudentTb>();
        }
    }
}
