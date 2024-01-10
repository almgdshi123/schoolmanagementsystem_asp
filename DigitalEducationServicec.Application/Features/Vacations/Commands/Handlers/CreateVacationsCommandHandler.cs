using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Vacations.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Vacations.Commands.Handlers
{
    public class CreateVacationsCommandHandler : ResponseHandler,
                                                      IRequestHandler<AddVacationsCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IVacationsService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateVacationsCommandHandler(IVacationsService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddVacationsCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and VacationsTb
            var data = _mapper.Map<VacationsTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
