using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.TypesDiscounts.Commands.Models
{
    public class AddTypesDiscountsCommand : IRequest<Response<string>>
    {

        public string? TypesDiscountName { get; set; }

        public string? Note { get; set; }

    }
}
