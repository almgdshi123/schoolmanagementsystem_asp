using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ParticiStudentActiv.Queries.Models;
using DigitalEducationServicec.Application.Features.ParticiStudentActiv.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.ParticiStudentActiv.Queries.Handlers
{
    public class ParticipStudentActivQueryHandler : ResponseHandler, IRequestHandler<GetParticiStudentActivListQuery, Response<List<GetParticiStudentActivListResponse>>>
    {
        private readonly IParticiStudentActivService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public ParticipStudentActivQueryHandler(IParticiStudentActivService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<List<GetParticiStudentActivListResponse>>> Handle(GetParticiStudentActivListQuery request, CancellationToken cancellationToken)
        {
            var activities = await _service.GetParticiStudentActivListAsync();
            var activitiesMapper = _mapper.Map<List<GetParticiStudentActivListResponse>>(activities);
            var result = Success(activitiesMapper);
            result.Meta = new { Count = activitiesMapper.Count() };
            return result;
        }
    }

}
