using DigitalEducationServicec.Application.Features.Installment.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Installment
{
    public partial class InstallmentProfile
    {
        public void GetInstallmentByIDMapping()
        {
            CreateMap<InstallmentTb, GetInstallmentByIDResponse>();
        }
    }
}
