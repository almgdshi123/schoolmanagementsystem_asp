using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Handlers
{
    public class UpdateAcademicStatusesCommandHandler : ResponseHandler,
                                       IRequestHandler<EditAcademicStatusCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IAcademicStatusService _service;

        #endregion

        #region Constructors
        public UpdateAcademicStatusesCommandHandler(IAcademicStatusService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(EditAcademicStatusCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.StatusId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //mapping Between request and data
            var datamapper = _mapper.Map(request, data);
            //Call service that make Edit
            var result = await _service.EditAsync(datamapper);
            //return response
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
            else return BadRequest<string>(_localizer[SharedResourcesKeys.Updated]);
        }
        #endregion

    }
}
