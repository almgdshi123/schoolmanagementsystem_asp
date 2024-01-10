using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Qualification.Queries.Models;
using DigitalEducationServicec.Application.Features.Qualification.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Qualification.Queries.Handlers
{
    public class QualificationQueryHandler : ResponseHandler,
                                       IRequestHandler<GetQualificationListQuery, Response<List<GetQualificationListResponse>>>


    {

        private readonly IMapper _mapper;
        private readonly IQualificationService _service;
        IStringLocalizer<SharedResources> _localizer;

        #region Constructors
        public QualificationQueryHandler(IQualificationService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        #region Handle Functions


        public async Task<Response<List<GetQualificationListResponse>>> Handle(GetQualificationListQuery request, CancellationToken cancellationToken)
        {
            var studentList = await _service.GetQualificationListAsync();
            var studentListMapper = _mapper.Map<List<GetQualificationListResponse>>(studentList);
            var result = Success(studentListMapper);
            result.Meta = new { Count = studentListMapper.Count() };
            return result;
        }
        #endregion

    }
}

