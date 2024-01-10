using DigitalEducationServicec.Application.Features.Preparation.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Preparation
{
    public partial class PreparationProfile
    {
        public void AddPreparationCommandMapping()
        {
            CreateMap<AddPreparationCommand, PreparationTb>();

        }
    }
}
