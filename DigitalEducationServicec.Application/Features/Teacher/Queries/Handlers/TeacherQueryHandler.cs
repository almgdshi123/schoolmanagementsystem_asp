using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Teacher.Queries.Models;
using DigitalEducationServicec.Application.Features.Teacher.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Teacher.Queries.Handlers
{
    public class TeacherQueryHandler : ResponseHandler,
                                       IRequestHandler<GetTeacherListQuery, Response<List<GetTeacherListResponse>>>


    {
        #region Fields
        private readonly ITeacherService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public TeacherQueryHandler(ITeacherService service,
                                     IMapper mapper,
                                     IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;
        }
        #endregion



        public async Task<Response<List<GetTeacherListResponse>>> Handle(GetTeacherListQuery request, CancellationToken cancellationToken)
        {
            var List = await _service.GetTeacherTbTbListAsync();
            var ListMapper = _mapper.Map<List<GetTeacherListResponse>>(List);
            var result = Success(ListMapper);
            result.Meta = new { Count = ListMapper.Count() };
            return result;
        }
    }
}