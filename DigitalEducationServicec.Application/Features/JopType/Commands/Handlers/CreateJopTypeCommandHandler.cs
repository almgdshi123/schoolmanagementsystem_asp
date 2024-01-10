using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.JopType.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.JopType.Commands.Handlers
{
    public class CreateJopTypeCommandHandler : ResponseHandler,
                                                     IRequestHandler<AddJopTypeCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IJopTypeService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateJopTypeCommandHandler(IJopTypeService service,
                                         IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddJopTypeCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and JopTypeTb
            var data = _mapper.Map<JopTypeTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}