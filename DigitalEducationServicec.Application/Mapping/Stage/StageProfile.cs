using AutoMapper;

namespace DigitalEducationServicec.Application.Mapping.Stage
{
    public partial class StageProfile : Profile
    {
        public StageProfile()
        {
            GetStageListMapping();
            GetStageByIDMapping();
            AddStageCommandMapping();
            EditStageCommandMapping();
        }
    }
}
