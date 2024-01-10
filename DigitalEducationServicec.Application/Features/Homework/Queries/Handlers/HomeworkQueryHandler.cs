using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Homework.Queries.Models;
using DigitalEducationServicec.Application.Features.Homework.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Homework.Queries.Handlers
{
    public class HomeworkQueryHandler : ResponseHandler,
                                       IRequestHandler<GetHomeworkListQuery, Response<List<GetHomeworkListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IHomeworkService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public HomeworkQueryHandler(IHomeworkService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetHomeworkListResponse>>> Handle(GetHomeworkListQuery request, CancellationToken cancellationToken)
        {
            var list = await _service.GetHomeworkListAsync();
            var listMapper = _mapper.Map<List<GetHomeworkListResponse>>(list);
            var result = Success(listMapper);
            result.Meta = new { Count = listMapper.Count() };
            return result;
        }


        #endregion



    }
}


