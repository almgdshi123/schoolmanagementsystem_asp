using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Streets.Queries.Models;
using DigitalEducationServicec.Application.Features.Streets.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Streets.Queries.Handlers
{
    public class StreetsQueryHandler : ResponseHandler, IRequestHandler<GetStreetsListQuery, Response<List<GetStreetsListResponse>>>
    {
        private readonly IStreetsService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public StreetsQueryHandler(IStreetsService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetStreetsListResponse>>> Handle(GetStreetsListQuery request, CancellationToken cancellationToken)
        {
            var streets = await _service.GetStreetsListAsync();
            var streetsList = _mapper.Map<List<GetStreetsListResponse>>(streets);
            var result = Success(streetsList);
            result.Meta = new { Count = streetsList.Count() };
            return result;
        }
    }

}
