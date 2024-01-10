using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Specialization.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Specialization.Commands.Handlers
{
    public class CreateSpecializationCommandHandler : ResponseHandler,
                                       IRequestHandler<AddSpecializationCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISpecializationService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateSpecializationCommandHandler(ISpecializationService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddSpecializationCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and Specialization
            var specializationtMapper = _mapper.Map<SpecializationTb>(request);
            //add
            var result = await _service.AddAsync(specializationtMapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}
