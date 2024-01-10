using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.StudentActivitie.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.StudentActivitie.Commands.Handlers
{

    public class CreateStudentActivitieCommandHandler : ResponseHandler,
                                                        IRequestHandler<AddStudentActivitieCommand, Response<string>>
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStudentActivitieService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateStudentActivitieCommandHandler(IStudentActivitieService service,
                                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddStudentActivitieCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and StudentActivitieTb
            var data = _mapper.Map<StudentActivitieTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
