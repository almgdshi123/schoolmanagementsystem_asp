using DigitalEducationServicec.Application.Features.TypesTuitionFees.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TypesTuitionFees
{
    public partial class TypesTuitionFeesProfile
    {
        public void EditTypesTuitionFeesCommandMapping()
        {
            CreateMap<EditTypesTuitionFeesCommand, TypesTuitionFeesTb>();
        }
    }
}
