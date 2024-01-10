using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Qualification.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Qualification.Commands.Handlers
{
    public class CreateQualificationCommandHandler : ResponseHandler,
                                       IRequestHandler<AddQualificationCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IQualificationService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateQualificationCommandHandler(IQualificationService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddQualificationCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and Qualification
            var qualificationMapper = _mapper.Map<QualificationTb>(request);
            //add
            var result = await _service.AddAsync(qualificationMapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}
