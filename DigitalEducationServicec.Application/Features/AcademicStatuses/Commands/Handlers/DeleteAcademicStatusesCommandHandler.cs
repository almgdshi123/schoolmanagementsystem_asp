using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicStatuses.Commands.Handlers
{
    internal class DeleteAcademicStatusesCommandHandler : ResponseHandler,
                                       IRequestHandler<DeleteAcademicStatusCommand, Response<string>>
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IAcademicStatusService _service;

        #endregion

        #region Constructors
        public DeleteAcademicStatusesCommandHandler(IAcademicStatusService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        #endregion


        public async Task<Response<string>> Handle(DeleteAcademicStatusCommand request, CancellationToken cancellationToken)
        {

            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.StatusId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>(_localizer[SharedResourcesKeys.Deleted]);
            else return BadRequest<string>();
        }
    }
}
