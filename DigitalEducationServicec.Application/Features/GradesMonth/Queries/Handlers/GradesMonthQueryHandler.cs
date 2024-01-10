using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.GradesMonth.Queries.Models;
using DigitalEducationServicec.Application.Features.GradesMonth.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.GradesMonth.Queries.Handlers
{
    public class GradesMonthQueryHandler : ResponseHandler,
                                       IRequestHandler<GetGradesMonthListQuery, Response<List<GetGradesMonthListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IGradesMonthService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public GradesMonthQueryHandler(IGradesMonthService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<List<GetGradesMonthListResponse>>> Handle(GetGradesMonthListQuery request, CancellationToken cancellationToken)
        {
            var list = await _service.GetGradesMonthListAsync();
            var listMapper = _mapper.Map<List<GetGradesMonthListResponse>>(list);
            var result = Success(listMapper);
            result.Meta = new { Count = listMapper.Count() };
            return result;
        }
    }
}
