using DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DistributionOfBuseStreet
{
    public partial class DistributionOfBuseStreetProfile
    {




        public void AddDistributionOfBuseStreetCommandMapping()
        {
            CreateMap<AddDistributionOfBuseStreetCommand, DistributionOfBuseStreetTb>();
        }
    }
}
