using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Preparation.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Preparation.Commands.Handlers
{
    public class CreatePreparationCommandHandler : ResponseHandler,
                                       IRequestHandler<AddPreparationCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IPreparationService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreatePreparationCommandHandler(IPreparationService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddPreparationCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and Preparation
            var preparationMapper = _mapper.Map<PreparationTb>(request);
            //add
            var result = await _service.AddAsync(preparationMapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}
