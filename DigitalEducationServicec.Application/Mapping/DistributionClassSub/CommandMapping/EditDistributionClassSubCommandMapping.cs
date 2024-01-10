using DigitalEducationServicec.Application.Features.DistributionClassSub.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DistributionClassSub
{
    public partial class DistributionClassSubProfile
    {
        public void EditDistributionClassSubCommandMapping()
        {
            CreateMap<EditDistributionClassSubCommand, DistributionClassSubTb>();

        }
    }
}


