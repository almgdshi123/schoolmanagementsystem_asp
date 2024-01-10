using DigitalEducationServicec.Application.Features.TrafficLine.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TrafficLine
{
    public partial class TrafficLineProfile
    {



        public void AddTrafficLineCommandMapping()
        {
            CreateMap<AddTrafficLineCommand, TrafficLineTb>();
        }

    }
}
