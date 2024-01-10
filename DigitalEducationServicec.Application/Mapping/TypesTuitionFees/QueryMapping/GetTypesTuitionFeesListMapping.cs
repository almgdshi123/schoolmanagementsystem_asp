using DigitalEducationServicec.Application.Features.TypesTuitionFees.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TypesTuitionFees
{
    public partial class TypesTuitionFeesProfile
    {
        public void GetTypesTuitionFeesListMapping()
        {
            CreateMap<TypesTuitionFeesTb, GetTypesTuitionFeesListResponse>();
        }
    }
}
