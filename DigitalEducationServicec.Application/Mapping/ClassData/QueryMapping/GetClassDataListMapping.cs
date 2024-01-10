using DigitalEducationServicec.Application.Features.ClassData.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.ClassData
{
    public partial class ClassDataProfile
    {
        public void GetClassDataListMapping()
        {
            CreateMap<ClassDataTb, GetClassDataListResponse>()
                               .ForMember(dest => dest.StageName, opt => opt.MapFrom(src => src.Stage.StageName))

                ;

        }
    }
}
