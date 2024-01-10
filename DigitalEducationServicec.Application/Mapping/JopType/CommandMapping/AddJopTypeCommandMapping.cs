using DigitalEducationServicec.Application.Features.JopType.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.JopType
{
    public partial class JopTypeProfile
    {
        public void AddJopTypeCommandMapping()
        {
            CreateMap<AddJopTypeCommand, JopTypeTb>();
        }
    }

}
