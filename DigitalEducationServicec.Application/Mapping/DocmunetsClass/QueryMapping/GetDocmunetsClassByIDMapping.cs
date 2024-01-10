using DigitalEducationServicec.Application.Features.DocmunetsClass.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.DocmunetsClass
{
    public partial class DocmunetsClassProfile
    {
        public void GetDocmunetsClassByIDMapping()
        {
            CreateMap<DocmunetsClassTb, GetDocmunetsClassListResponse>();
        }
    }

}
