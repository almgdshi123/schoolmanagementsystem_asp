using DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TuitionFeeInstallment
{
    public partial class TuitionFeeInstallmentProfile
    {
        void GetTuitionFeeInstallmentListMapping()
        {
            CreateMap<TuitionFeeInstallmentTb, GetTuitionFeeInstallmentListResponse>();
        }
    }
}
