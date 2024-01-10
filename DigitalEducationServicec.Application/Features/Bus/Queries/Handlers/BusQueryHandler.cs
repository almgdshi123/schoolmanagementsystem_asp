using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Bus.Queries.Models;
using DigitalEducationServicec.Application.Features.Bus.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Bus.Queries.Handlers
{
    public class BusQueryHandler : ResponseHandler, IRequestHandler<GetBusListQuery, Response<List<GetBusListResponse>>>
    {
        private readonly IBusService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public BusQueryHandler(IBusService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetBusListResponse>>> Handle(GetBusListQuery request, CancellationToken cancellationToken)
        {
            var buses = await _service.GetBusListAsync();
            var busList = _mapper.Map<List<GetBusListResponse>>(buses);
            var result = Success(busList);
            result.Meta = new { Count = busList.Count() };
            return result;
        }
    }
}