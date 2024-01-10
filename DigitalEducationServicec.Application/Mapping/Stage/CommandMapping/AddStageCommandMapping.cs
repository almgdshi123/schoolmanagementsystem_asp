using DigitalEducationServicec.Application.Features.Stage.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Stage
{
    public partial class StageProfile
    {
        public void AddStageCommandMapping()
        {
            CreateMap<AddStageCommand, StageTb>()
                ;

        }
    }
}
