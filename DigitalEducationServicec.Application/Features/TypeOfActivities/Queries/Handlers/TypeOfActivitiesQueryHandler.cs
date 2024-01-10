using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypeOfActivities.Queries.Models;
using DigitalEducationServicec.Application.Features.TypeOfActivities.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TypeOfActivities.Queries.Handlers
{
    public class TypeOfActivitiesQueryHandler : ResponseHandler, IRequestHandler<GetTypeOfActivitiesListQuery, Response<List<GetTypeOfActivitiesListResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly ITypeOfActivitiesService _service;

        private readonly IStringLocalizer<SharedResources> _localizer;

        public TypeOfActivitiesQueryHandler(ITypeOfActivitiesService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetTypeOfActivitiesListResponse>>> Handle(GetTypeOfActivitiesListQuery request, CancellationToken cancellationToken)
        {
            var types = await _service.GetTypeOfActivitiesListAsync();
            var typesMapper = _mapper.Map<List<GetTypeOfActivitiesListResponse>>(types);
            var result = Success(typesMapper);
            result.Meta = new { Count = typesMapper.Count() };
            return result;
        }
    }

}
