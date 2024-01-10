using DigitalEducationServicec.Application.Features.TypesDiscounts.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TypesDiscounts
{
    public partial class TypesDiscountsProfile
    {
        public void GetTypesDiscountsByIDMapping()
        {
            CreateMap<TypesDiscountsTb, GetTypesDiscountsListResponse>();
        }
    }
}
