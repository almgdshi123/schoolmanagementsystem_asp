using DigitalEducationServicec.Application.Features.Parent.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Parent
{
    public partial class ParentProfile
    {
        public void GetParentByIDMapping()
        {
            CreateMap<ParentTb, GetParentListResponse>();

        }

    }
}
