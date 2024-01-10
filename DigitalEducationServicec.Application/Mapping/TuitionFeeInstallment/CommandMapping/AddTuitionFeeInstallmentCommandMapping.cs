using DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TuitionFeeInstallment
{
    public partial class TuitionFeeInstallmentProfile
    {

        void AddTuitionFeeInstallmentCommandMapping()
        {
            CreateMap<AddTuitionFeeInstallmentCommand, TuitionFeeInstallmentTb>();
        }
    }
}
