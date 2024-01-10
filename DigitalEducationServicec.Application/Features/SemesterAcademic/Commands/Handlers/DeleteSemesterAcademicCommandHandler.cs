using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SemesterAcademic.Commands.Handlers
{
    public class DeleteSemesterAcademicCommandHandler : ResponseHandler,
                                       IRequestHandler<DeleteSemesterAcademicCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISemesterAcademicService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public DeleteSemesterAcademicCommandHandler(ISemesterAcademicService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(DeleteSemesterAcademicCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.SemesterAcademicId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }
    }
}
