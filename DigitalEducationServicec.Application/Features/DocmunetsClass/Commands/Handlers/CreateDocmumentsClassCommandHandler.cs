using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DocmunetsClass.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DocmunetsClass.Commands.Handlers
{
    public class CreateDocmumentsClassCommandHandler : ResponseHandler,
                                                     IRequestHandler<AddDocmunetsClassCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IDocmumentsClassService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateDocmumentsClassCommandHandler(IDocmumentsClassService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddDocmunetsClassCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and DocumentsClassTb
            var data = _mapper.Map<DocmunetsClassTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
