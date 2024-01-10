using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Handlers
{
    public class CreateSemesterAcademicCommandHandler : ResponseHandler,
                                       IRequestHandler<AddSemesterAcademicCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISemesterAcademicService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateSemesterAcademicCommandHandler(ISemesterAcademicService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(AddSemesterAcademicCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and SemesterAcademic
            var semesterAcademic = _mapper.Map<SemesterAcademicTb>(request);
            //add
            var result = await _service.AddAsync(semesterAcademic);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}
