using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Installment
{
    public partial class InstallmentProfile : Profile
    {
        public InstallmentProfile()
        {
            AddInstallmentCommandMapping();
            EditInstallmentCommandMapping();
            GetInstallmentListMapping();
            GetInstallmentByIDMapping();
        }


    }


}
