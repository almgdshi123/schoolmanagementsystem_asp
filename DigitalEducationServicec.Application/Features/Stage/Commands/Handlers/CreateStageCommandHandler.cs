using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Stage.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Stage.Commands.Handlers
{
    public class CreateStageCommandHandler : ResponseHandler,
                                       IRequestHandler<AddStageCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStageService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public CreateStageCommandHandler(IStageService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(AddStageCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and ClassDataTb
            var data = _mapper.Map<StageTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }

    }
}
