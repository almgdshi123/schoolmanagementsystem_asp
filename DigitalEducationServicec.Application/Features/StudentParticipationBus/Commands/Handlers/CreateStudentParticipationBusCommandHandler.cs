using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.StudentParticipationBus.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.StudentParticipationBus.Commands.Handlers
{
    public class CreateStudentParticipationBusCommandHandler : ResponseHandler,
                                                           IRequestHandler<AddStudentParticipationBusCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStudentParticipationBusService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateStudentParticipationBusCommandHandler(IStudentParticipationBusService service,
                                                         IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddStudentParticipationBusCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and StudentParticipationBusTb
            var data = _mapper.Map<StudentParticipationBusTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}