using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.TuitionFeeInstallment
{

    public partial class TuitionFeeInstallmentProfile : Profile
    {
        public TuitionFeeInstallmentProfile()
        {
            GetTuitionFeeInstallmentListMapping();
            GetTuitionFeeInstallmentByIDMapping();
            AddTuitionFeeInstallmentCommandMapping();
            EditTuitionFeeInstallmentCommandMapping();
        }


    }
}
