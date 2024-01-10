using DigitalEducationServicec.Application.Features.SectionCode.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SectionCode
{
    public partial class SectionCodeProfile
    {
        public void EditSectionCodeCommandMapping()
        {
            CreateMap<EditSectionCodeCommand, SectionCodeTb>();
        }
    }
}
