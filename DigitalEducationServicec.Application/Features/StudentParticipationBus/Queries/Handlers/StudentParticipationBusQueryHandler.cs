using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.StudentParticipationBus.Queries.Models;
using DigitalEducationServicec.Application.Features.StudentParticipationBus.Queries.Results;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.StudentParticipationBus.Queries.Handlers
{
    public class StudentParticipationBusQueryHandler : ResponseHandler, IRequestHandler<GetStudentParticipationBusListQuery, Response<List<GetStudentParticipationBusListResponse>>>
    {
        private readonly IStudentParticipationBusService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;

        public StudentParticipationBusQueryHandler(IStudentParticipationBusService service, IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<List<GetStudentParticipationBusListResponse>>> Handle(GetStudentParticipationBusListQuery request, CancellationToken cancellationToken)
        {
            var studentParticipationBuses = await _service.GetStudentParticipationBusListAsync();
            var studentParticipationBusList = _mapper.Map<List<GetStudentParticipationBusListResponse>>(studentParticipationBuses);
            var result = Success(studentParticipationBusList);
            result.Meta = new { Count = studentParticipationBusList.Count() };
            return result;
        }
    }

}
