using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SubmittedHomework.Queries.Models;
using DigitalEducationServicec.Application.Features.SubmittedHomework.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SubmittedHomework.Queries.Handlers
{
    public class SubmittedHomeworkQueryHandler : ResponseHandler,
                                       IRequestHandler<GetSubmittedHomeworkListQuery, Response<List<GetSubmittedHomeworkListResponse>>>


    {
        #region Fields
        private readonly ISubmittedHomeworkService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public SubmittedHomeworkQueryHandler(ISubmittedHomeworkService service,
                                     IMapper mapper,
                                     IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;
        }
        #endregion



        public async Task<Response<List<GetSubmittedHomeworkListResponse>>> Handle(GetSubmittedHomeworkListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetSubmittedHomeworkListAsync();
            var ListMapper = _mapper.Map<List<GetSubmittedHomeworkListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
    }
}