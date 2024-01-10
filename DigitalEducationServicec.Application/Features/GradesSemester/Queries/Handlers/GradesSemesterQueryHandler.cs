using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.GradesSemester.Queries.Models;
using DigitalEducationServicec.Application.Features.GradesSemester.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.GradesSemester.Queries.Handlers
{
    public class GradesSemesterQueryHandler : ResponseHandler,
                                       IRequestHandler<GetGradesSemesterListQuery, Response<List<GetGradesSemesterListResponse>>>


    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IGradesSemesterService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public GradesSemesterQueryHandler(IGradesSemesterService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<List<GetGradesSemesterListResponse>>> Handle(GetGradesSemesterListQuery request, CancellationToken cancellationToken)
        {
            var list = await _service.GetGradesSemesterListAsync();
            var listMapper = _mapper.Map<List<GetGradesSemesterListResponse>>(list);
            var result = Success(listMapper);
            result.Meta = new { Count = listMapper.Count() };
            return result;
        }
    }
}
