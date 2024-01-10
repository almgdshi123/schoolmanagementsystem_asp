using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Handlers
{
    internal class CreateAcademicSystemsCommandHandler : ResponseHandler,
                                       IRequestHandler<AddAcademicSystemCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IAcademicSystemService _service;

        #endregion

        #region Constructors
        public CreateAcademicSystemsCommandHandler(IAcademicSystemService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        #endregion

        public async Task<Response<string>> Handle(AddAcademicSystemCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and AcademicSystemsTb
            var data = _mapper.Map<AcademicSystemsTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }


    }
}




