using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TypesTuitionFees.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TypesTuitionFees.Commands.Handlers
{
    public class CreateTypesTuitionFeesCommandHandler : ResponseHandler,
                                                     IRequestHandler<AddTypesTuitionFeesCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ITypesTuitionFeesService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateTypesTuitionFeesCommandHandler(ITypesTuitionFeesService service,
                                                   IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddTypesTuitionFeesCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and TypesTuitionFeesTb
            var data = _mapper.Map<TypesTuitionFeesTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}