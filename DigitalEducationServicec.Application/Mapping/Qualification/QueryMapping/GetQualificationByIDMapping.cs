using DigitalEducationServicec.Application.Features.Qualification.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Qualification
{
    public partial class QualificationProfile
    {
        public void GetQualificationByIDMapping()
        {
            CreateMap<QualificationTb, GetQualificationListResponse>();

        }


    }
}
