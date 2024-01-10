using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TrafficLine.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TrafficLine.Commands.Handlers
{
    public class CreateTrafficLineCommandHandler : ResponseHandler,
                                                   IRequestHandler<AddTrafficLineCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ITrafficLineService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateTrafficLineCommandHandler(ITrafficLineService service,
                                             IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddTrafficLineCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and TrafficLineTb
            var data = _mapper.Map<TrafficLineTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}