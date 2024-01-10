using DigitalEducationServicec.Application.Features.Bus.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Bus
{
    public partial class BusProfile
    {



        public void AddBusCommandMapping()
        {
            CreateMap<AddBusCommand, BusTb>();
        }
    }
}