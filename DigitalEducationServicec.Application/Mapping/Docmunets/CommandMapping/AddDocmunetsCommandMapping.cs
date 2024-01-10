using DigitalEducationServicec.Application.Features.Docmunets.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Docmunets
{
    public partial class DocmunetsProfile
    {
        public void AddDocmunetsCommandMapping()
        {
            CreateMap<AddDocmunetsCommand, DocmunetsTb>();
        }



    }
}
