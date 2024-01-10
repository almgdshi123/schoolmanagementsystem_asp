using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Teacher.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Teacher.Commands.Handlers
{
    public class CreateTeacherCommandHandler : ResponseHandler,
                                       IRequestHandler<AddTeacherCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ITeacherService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateTeacherCommandHandler(ITeacherService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(AddTeacherCommand request, CancellationToken cancellationToken)
        {

            //mapping Between request and Teacher
            var data = _mapper.Map<TeacherTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
    }
}
