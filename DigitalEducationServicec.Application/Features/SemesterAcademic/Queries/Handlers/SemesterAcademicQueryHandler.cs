using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Models;
using DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SemesterAcademic.Queries.Handlers
{
    public class SemesterAcademicQueryHandler : ResponseHandler,
                                       IRequestHandler<GetSemesterAcademicListQuery, Response<List<GetSemesterAcademicListResponse>>>


    {

        private readonly IMapper _mapper;
        private readonly ISemesterAcademicService _service;
        IStringLocalizer<SharedResources> _localizer;

        #region Constructors
        public SemesterAcademicQueryHandler(ISemesterAcademicService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        #region Handle Functions


        public async Task<Response<List<GetSemesterAcademicListResponse>>> Handle(GetSemesterAcademicListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _service.GetSectionDataListAsync();
            var studentListMapper = _mapper.Map<List<GetSemesterAcademicListResponse>>(studentList);
            var result = Success(studentListMapper);
            result.Meta = new { Count = studentListMapper.Count() };
            return result;
        }
        #endregion

    }
}
