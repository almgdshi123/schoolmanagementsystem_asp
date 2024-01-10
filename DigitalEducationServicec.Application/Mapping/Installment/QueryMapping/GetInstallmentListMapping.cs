using DigitalEducationServicec.Application.Features.Installment.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Installment
{
    public partial class InstallmentProfile
    {
        public void GetInstallmentListMapping()
        {
            CreateMap<InstallmentTb, GetInstallmentListResponse>();
        }

    }
}
