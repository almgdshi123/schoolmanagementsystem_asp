using DigitalEducationServicec.Application.Bases;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TypesDiscounts.Commands.Models
{
    public class DeleteTypesDiscountsCommand : IRequest<Response<string>>
    {
        public long TypesDiscountId { get; set; }

    }
}
