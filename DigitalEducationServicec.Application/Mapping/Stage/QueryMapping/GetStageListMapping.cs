using DigitalEducationServicec.Application.Features.Stage.Queries.Results;
using DigitalEducationServicec.Domain.Entity;
using static DigitalEducationServicec.Application.Features.Stage.Queries.Results.GetStageListResponse;

namespace DigitalEducationServicec.Application.Mapping.Stage
{
    public partial class StageProfile
    {
        public void GetStageListMapping()
        {
            CreateMap<StageTb, GetStageListResponse>()

                ;
            CreateMap<ClassDataTb, ClassDataTbResponse>();


        }
    }
}
