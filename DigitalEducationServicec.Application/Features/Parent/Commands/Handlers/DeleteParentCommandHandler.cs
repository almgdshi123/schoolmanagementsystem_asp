using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Parent.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Parent.Commands.Handlers
{
    public class DeleteParentCommandHandler : ResponseHandler,
                                       IRequestHandler<DeleteParentCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IParentService _service;

        #endregion

        #region Constructors
        public DeleteParentCommandHandler(IParentService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            // _localizer = localizer;

        }

        public async Task<Response<string>> Handle(DeleteParentCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.ParentId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }

        #endregion


        #region Handle Functions


        #endregion


    }
}
