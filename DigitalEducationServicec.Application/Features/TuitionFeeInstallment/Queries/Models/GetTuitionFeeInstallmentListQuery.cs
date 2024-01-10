using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Queries.Results;
using MediatR;


namespace DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Queries.Models
{
    public class GetTuitionFeeInstallmentListQuery : IRequest<Response<List<GetTuitionFeeInstallmentListResponse>>>
    {
    }
}
