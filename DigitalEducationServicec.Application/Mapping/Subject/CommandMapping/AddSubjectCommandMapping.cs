using DigitalEducationServicec.Application.Features.Subject.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Subject
{
    public partial class SubjectProfile

    {
        public void AddSubjectCommandMapping()
        {
            CreateMap<AddSubjectCommand, SubjectTb>();

        }


    }
}
