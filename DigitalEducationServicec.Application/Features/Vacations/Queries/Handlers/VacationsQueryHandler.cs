using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Vacations.Queries.Models;
using DigitalEducationServicec.Application.Features.Vacations.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Vacations.Queries.Handlers
{
    public class VacationsQueryHandler : ResponseHandler, IRequestHandler<GetVacationsListQuery, Response<List<GetVacationsListResponse>>>
    {
        private readonly IMapper _mapper;
        private readonly IVacationsService _service;

        private readonly IStringLocalizer<SharedResources> _localizer;



        public VacationsQueryHandler(IVacationsService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }



        public async Task<Response<List<GetVacationsListResponse>>> Handle(GetVacationsListQuery request, CancellationToken cancellationToken)
        {
            var vacations = await _service.GetVacationsListAsync();
            var vacationsList = _mapper.Map<List<GetVacationsListResponse>>(vacations);
            var result = Success(vacationsList);
            result.Meta = new { Count = vacationsList.Count() };
            return result;
        }

    }
}