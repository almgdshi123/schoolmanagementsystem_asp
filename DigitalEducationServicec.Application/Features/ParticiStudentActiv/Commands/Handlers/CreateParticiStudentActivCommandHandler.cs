using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ParticiStudentActiv.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.ParticiStudentActiv.Commands.Handlers
{
    public class CreateParticiStudentActivCommandHandler : ResponseHandler,
                                                        IRequestHandler<AddParticiStudentActivCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IParticiStudentActivService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateParticiStudentActivCommandHandler(IParticiStudentActivService service,
                                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddParticiStudentActivCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and ParticipStudentActivTb
            var data = _mapper.Map<ParticiStudentActivTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
