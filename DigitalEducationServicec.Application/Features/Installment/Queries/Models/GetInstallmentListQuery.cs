using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Installment.Queries.Results;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Installment.Queries.Models
{
    public class GetInstallmentListQuery : IRequest<Response<List<GetInstallmentListResponse>>>
    {
    }
}
