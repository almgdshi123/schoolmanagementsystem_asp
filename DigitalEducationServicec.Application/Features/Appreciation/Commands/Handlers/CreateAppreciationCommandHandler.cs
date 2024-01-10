using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Appreciation.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Appreciation.Commands.Handlers
{
    public class CreateAppreciationCommandHandler : ResponseHandler,
                                         IRequestHandler<AddAppreciationCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IAppreciationService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateAppreciationCommandHandler(IAppreciationService service,
                                         IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddAppreciationCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and AppreciationTb
            var data = _mapper.Map<AppreciationTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }

}
