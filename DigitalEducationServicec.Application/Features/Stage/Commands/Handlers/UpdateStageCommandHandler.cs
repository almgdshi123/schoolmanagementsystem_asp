using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Stage.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Stage.Commands.Handlers
{
    internal class UpdateStageCommandHandler : ResponseHandler,
                                       IRequestHandler<EditStageCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStageService _service;
        IStringLocalizer<SharedResources> _localizer;

        #endregion

        #region Constructors
        public UpdateStageCommandHandler(IStageService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(EditStageCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.StageId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //mapping Between request and data
            var datamapper = _mapper.Map(request, data);
            //Call service that make Edit
            var result = await _service.EditAsync(datamapper);
            //return response
            //return response
            if (result == "Success") return Success("تم التعديل");
            else return BadRequest<string>();
        }
        #endregion


    }
}
