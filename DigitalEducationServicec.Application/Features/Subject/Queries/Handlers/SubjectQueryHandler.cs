

using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Subject.Queries.Models;
using DigitalEducationServicec.Application.Features.Subject.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Subject.Queries.Handlers
{
    public class SubjectQueryHandler : ResponseHandler,
                                       IRequestHandler<GetSubjectListQuery, Response<List<GetSubjectListResponse>>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISubjectService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public SubjectQueryHandler(ISubjectService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<List<GetSubjectListResponse>>> Handle(GetSubjectListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetSubjectListAsync();
            var ListMapper = _mapper.Map<List<GetSubjectListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
    }
}