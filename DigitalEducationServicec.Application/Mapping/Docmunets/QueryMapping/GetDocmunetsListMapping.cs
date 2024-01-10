using DigitalEducationServicec.Application.Features.Docmunets.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Docmunets
{

    public partial class DocmunetsProfile
    {
        public void GetDocmunetsListMapping()
        {
            CreateMap<DocmunetsTb, GetDocmunetsListResponse>();
        }


    }

}

