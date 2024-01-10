using DigitalEducationServicec.Application.Features.TypesDiscounts.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.TypesDiscounts
{
    public partial class TypesDiscountsProfile
    {
        public void AddTypesDiscountsCommandMapping()
        {
            CreateMap<AddTypesDiscountsCommand, TypesDiscountsTb>();
        }
    }

}
