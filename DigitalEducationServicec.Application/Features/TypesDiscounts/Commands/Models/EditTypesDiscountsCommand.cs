using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TypesDiscounts.Commands.Models
{
    public class EditTypesDiscountsCommand : IRequest<Response<string>>
    {
        public long TypesDiscountId { get; set; }

        public string? TypesDiscountName { get; set; }

        public string? Note { get; set; }
    }
}
