using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Grades.Queries.Models;
using DigitalEducationServicec.Application.Features.Grades.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Grades.Queries.Handlers
{
    public class GradesQueryHandler : ResponseHandler,
                                       IRequestHandler<GetGradesListQuery, Response<List<GetGradesListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IGradesService _service;

        #endregion

        #region Constructors
        public GradesQueryHandler(IGradesService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<List<GetGradesListResponse>>> Handle(GetGradesListQuery request, CancellationToken cancellationToken)
        {
            var list = await _service.GetListAsync();
            var listMapper = _mapper.Map<List<GetGradesListResponse>>(list);
            var result = Success(listMapper);
            result.Meta = new { Count = listMapper.Count() };
            return result;
        }
    }
}
