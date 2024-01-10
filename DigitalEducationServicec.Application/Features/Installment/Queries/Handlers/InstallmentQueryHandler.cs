using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Installment.Queries.Models;
using DigitalEducationServicec.Application.Features.Installment.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Installment.Queries.Handlers
{
    public class InstallmentQueryHandler : ResponseHandler, IRequestHandler<GetInstallmentListQuery, Response<List<GetInstallmentListResponse>>>
    {
        private readonly IInstallmentService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public InstallmentQueryHandler(IInstallmentService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<List<GetInstallmentListResponse>>> Handle(GetInstallmentListQuery request, CancellationToken cancellationToken)
        {
            var installments = await _service.GetInstallmentListAsync();
            var installmentList = _mapper.Map<List<GetInstallmentListResponse>>(installments);
            var result = Success(installmentList);
            result.Meta = new { Count = installmentList.Count() };
            return result;
        }
    }

}
