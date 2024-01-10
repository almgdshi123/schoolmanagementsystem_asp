using DigitalEducationServicec.Application.Features.Fines.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Fines
{
    public partial class FinesProfile
    {

        public void GetFinesByIDMapping()
        {
            CreateMap<FinesTb, GetFinesByIDResponse>();
        }
    }
}
