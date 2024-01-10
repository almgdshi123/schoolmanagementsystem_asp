using DigitalEducationServicec.Application.Features.Preparation.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Preparation
{
    public partial class PreparationProfile
    {
        public void GetPreparationByIDMapping()
        {
            CreateMap<PreparationTb, GetPreparationListResponse>();

        }


    }
}
