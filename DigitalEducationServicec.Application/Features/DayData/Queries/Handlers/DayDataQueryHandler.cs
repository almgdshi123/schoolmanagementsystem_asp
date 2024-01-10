using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DayData.Queries.Models;
using DigitalEducationServicec.Application.Features.DayData.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DayData.Queries.Handlers
{
    public class DayDataQueryHandler : ResponseHandler, IRequestHandler<GetDayDataListQuery, Response<List<GetDayDataListResponse>>>
    {
        private readonly IDayDataService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public DayDataQueryHandler(IDayDataService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }


        public async Task<Response<List<GetDayDataListResponse>>> Handle(GetDayDataListQuery request, CancellationToken cancellationToken)
        {
            var days = await _service.GetDayDataListAsync();
            var dayList = _mapper.Map<List<GetDayDataListResponse>>(days);
            var result = Success(dayList);
            result.Meta = new { Count = dayList.Count() };
            return result;
        }
    }

}
