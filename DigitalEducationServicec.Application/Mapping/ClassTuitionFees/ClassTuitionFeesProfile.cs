using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.ClassTuitionFees
{
    public partial class ClassTuitionFeesProfile : Profile
    {
        public ClassTuitionFeesProfile()
        {
            ClassTuitionFeesListMapping();
            ClassTuitionFeesByIDMapping();
            AddClassTuitionFeesCommandMapping();
            EditClassTuitionFeesCommandMapping();
        }
    }



}