using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Docmunets.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Docmunets.Commands.Handlers
{
    public class CreateDocmumentsCommandHandler : ResponseHandler,
                                                 IRequestHandler<AddDocmunetsCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IDocmumentsService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateDocmumentsCommandHandler(IDocmumentsService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;
        }

        public async Task<Response<string>> Handle(AddDocmunetsCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and DocmumentsTb
            var data = _mapper.Map<DocmunetsTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
