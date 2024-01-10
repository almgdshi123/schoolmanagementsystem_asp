using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Queries.Models;
using DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Queries.Handlers
{
    public class DistributionOfBusesStreetQueryHandler : ResponseHandler, IRequestHandler<GetDistributionOfBuseStreetListQuery, Response<List<GetDistributionOfBuseStreetListResponse>>>
    {
        private readonly IDistributionOfBuseStreetService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public DistributionOfBusesStreetQueryHandler(IDistributionOfBuseStreetService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetDistributionOfBuseStreetListResponse>>> Handle(GetDistributionOfBuseStreetListQuery request, CancellationToken cancellationToken)
        {
            var buses = await _service.GetDistributionOfBuseStreetListAsync();
            var busList = _mapper.Map<List<GetDistributionOfBuseStreetListResponse>>(buses);
            var result = Success(busList);
            result.Meta = new { Count = busList.Count() };
            return result;
        }
    }

}
