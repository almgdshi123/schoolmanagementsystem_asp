using DigitalEducationServicec.Application.Features.Qualification.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Qualification
{
    public partial class QualificationProfile
    {
        public void EditQualificationCommandMapping()
        {
            CreateMap<EditQualificationCommand, QualificationTb>();

        }


    }
}
