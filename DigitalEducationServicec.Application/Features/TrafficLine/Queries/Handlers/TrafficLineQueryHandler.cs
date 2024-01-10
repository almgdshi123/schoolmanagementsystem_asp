using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TrafficLine.Queries.Models;
using DigitalEducationServicec.Application.Features.TrafficLine.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TrafficLine.Queries.Handlers
{
    public class TrafficLineQueryHandler : ResponseHandler, IRequestHandler<GetTrafficLineListQuery, Response<List<GetTrafficLineListResponse>>>
    {
        private readonly ITrafficLineService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public TrafficLineQueryHandler(ITrafficLineService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetTrafficLineListResponse>>> Handle(GetTrafficLineListQuery request, CancellationToken cancellationToken)
        {
            var lines = await _service.GetTrafficLineListAsync();
            var lineList = _mapper.Map<List<GetTrafficLineListResponse>>(lines);
            var result = Success(lineList);
            result.Meta = new { Count = lineList.Count() };
            return result;
        }
    }

}
