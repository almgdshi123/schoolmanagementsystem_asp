using DigitalEducationServicec.Application.Features.SectionData.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SectionData
{
    public partial class SectionDataProfile

    {
        public void EditSectionDataCommandMapping()
        {
            CreateMap<EditSectionDataCommand, SectionDataTb>();

        }


    }
}
