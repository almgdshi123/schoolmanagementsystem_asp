using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Appreciation.Queries.Models;
using DigitalEducationServicec.Application.Features.Appreciation.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Appreciation.Queries.Handlers
{
    public class AppreciationQueryHandler : ResponseHandler, IRequestHandler<GetAppreciationListQuery, Response<List<GetAppreciationListResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly IAppreciationService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public AppreciationQueryHandler(IAppreciationService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Response<List<GetAppreciationListResponse>>> Handle(GetAppreciationListQuery request, CancellationToken cancellationToken)
        {
            var list = await _service.GetAppreciationListAsync();
            var listMapper = _mapper.Map<List<GetAppreciationListResponse>>(list);
            var result = Success(listMapper);
            result.Meta = new { Count = listMapper.Count() };
            return result;
        }
    }
}