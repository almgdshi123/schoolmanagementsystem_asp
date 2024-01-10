using DigitalEducationServicec.Application.Features.Specialization.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Specialization
{
    public partial class SpecializationProfile

    {
        public void EditSpecializationCommandMapping()
        {
            CreateMap<EditSpecializationCommand, SpecializationTb>();

        }


    }
}
