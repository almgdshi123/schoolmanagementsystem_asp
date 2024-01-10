using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Models;
using DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.MonthAcademic.Queries.Handlers
{
    public class MonthAcademicQueryHandler : ResponseHandler,
                                       IRequestHandler<GetMonthAcademicListQuery, Response<List<GetMonthAcademicListResponse>>>


    {

        private readonly IMapper _mapper;
        private readonly IMonthAcademicService _service;
        IStringLocalizer<SharedResources> _localizer;

        #region Constructors
        public MonthAcademicQueryHandler(IMonthAcademicService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        #region Handle Functions


        public async Task<Response<List<GetMonthAcademicListResponse>>> Handle(GetMonthAcademicListQuery request, CancellationToken cancellationToken)
        {
            var list = await _service.GetMonthAcademicListAsync();
            var listMapper = _mapper.Map<List<GetMonthAcademicListResponse>>(list);
            var result = Success(listMapper);
            result.Meta = new { Count = listMapper.Count() };
            return result;
        }
        #endregion

    }
}

