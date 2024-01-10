using DigitalEducationServicec.Application.Features.Bus.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Bus
{
    public partial class BusProfile
    {
        public void GetBusListMapping()
        {
            CreateMap<BusTb, GetBusListResponse>();
        }

    }
}
