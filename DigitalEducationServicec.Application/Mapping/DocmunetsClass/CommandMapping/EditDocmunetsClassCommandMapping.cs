using DigitalEducationServicec.Application.Features.DocmunetsClass.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DocmunetsClass
{
    public partial class DocmunetsClassProfile
    {
        public void EditDocmunetsClassCommandMapping()
        {
            CreateMap<EditDocmunetsClassCommand, DocmunetsClassTb>();
        }
    }

}
