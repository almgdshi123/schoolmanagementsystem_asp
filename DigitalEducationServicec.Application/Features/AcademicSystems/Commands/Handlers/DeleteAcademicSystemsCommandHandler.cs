using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicSystems.Commands.Handlers
{
    public class DeleteAcademicSystemsCommandHandler : ResponseHandler,
                                       IRequestHandler<DeleteAcademicSystemCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IAcademicSystemService _service;

        #endregion

        #region Constructors
        public DeleteAcademicSystemsCommandHandler(IAcademicSystemService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }


        public async Task<Response<string>> Handle(DeleteAcademicSystemCommand request, CancellationToken cancellationToken)
        {

            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.SystemId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }
        #endregion

    }
}
