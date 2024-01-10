using DigitalEducationServicec.Application.Features.Stage.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Stage
{
    public partial class StageProfile
    {
        public void GetStageByIDMapping()
        {
            CreateMap<StageTb, GetStageListResponse>()
                ;

        }

    }
}
