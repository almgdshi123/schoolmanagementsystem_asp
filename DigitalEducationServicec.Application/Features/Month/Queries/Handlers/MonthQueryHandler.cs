using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Month.Queries.Models;
using DigitalEducationServicec.Application.Features.Month.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Month.Queries.Handlers
{
    public class MonthQueryHandler : ResponseHandler,
                                       IRequestHandler<GetMonthListQuery, Response<List<GetMonthListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IMonthService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public MonthQueryHandler(IMonthService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<List<GetMonthListResponse>>> Handle(GetMonthListQuery request, CancellationToken cancellationToken)
        {

            var list = await _service.GetMonthListAsync();
            var listMapper = _mapper.Map<List<GetMonthListResponse>>(list);
            var result = Success(listMapper);
            result.Meta = new { Count = listMapper.Count() };
            return result;
        }
    }
}

