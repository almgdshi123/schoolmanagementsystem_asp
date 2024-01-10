using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Handlers
{
    public class CreateAcademicStatusesCommandHandler : ResponseHandler,
                                       IRequestHandler<AddAcademicStatusCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IAcademicStatusService _service;

        #endregion

        #region Constructors
        public CreateAcademicStatusesCommandHandler(IAcademicStatusService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        public async Task<Response<string>> Handle(AddAcademicStatusCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and AcademicStatusesTb
            var AcademicStatusesTb = _mapper.Map<AcademicStatusesTb>(request);
            //add
            var result = await _service.AddAsync(AcademicStatusesTb);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>(_localizer[SharedResourcesKeys.BadRequest]);
        }
        #endregion

    }

}
