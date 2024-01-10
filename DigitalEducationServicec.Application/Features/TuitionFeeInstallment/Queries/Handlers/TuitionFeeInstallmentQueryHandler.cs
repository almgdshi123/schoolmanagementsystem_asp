using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Queries.Models;
using DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Queries.Handlers
{
    public class TuitionFeeInstallmentQueryHandler : ResponseHandler, IRequestHandler<GetTuitionFeeInstallmentListQuery, Response<List<GetTuitionFeeInstallmentListResponse>>>
    {
        private readonly ITuitionFeeInstallmentService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public TuitionFeeInstallmentQueryHandler(ITuitionFeeInstallmentService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<List<GetTuitionFeeInstallmentListResponse>>> Handle(GetTuitionFeeInstallmentListQuery request, CancellationToken cancellationToken)
        {
            var installments = await _service.GetTuitionFeeInstallmentListAsync();
            var installmentList = _mapper.Map<List<GetTuitionFeeInstallmentListResponse>>(installments);
            var result = Success(installmentList);
            result.Meta = new { Count = installmentList.Count() };
            return result;
        }
    }

}
