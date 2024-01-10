using DigitalEducationServicec.Application.Features.ClassTuitionFees.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.ClassTuitionFees
{
    public partial class ClassTuitionFeesProfile
    {



        public void EditClassTuitionFeesCommandMapping()
        {
            CreateMap<EditClassTuitionFeesCommand, ClassTuitionFeesTb>();
        }
    }

}
