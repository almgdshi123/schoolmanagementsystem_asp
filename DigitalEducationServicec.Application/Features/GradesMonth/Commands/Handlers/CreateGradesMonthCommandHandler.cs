using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.GradesMonth.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.GradesMonth.Commands.Handlers
{
    public class CreateGradesMonthCommandHandler : ResponseHandler,
                                       IRequestHandler<AddGradesMonthCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IGradesMonthService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateGradesMonthCommandHandler(IGradesMonthService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddGradesMonthCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and GradesSemester
            var mapper = _mapper.Map<GradesMonthTb>(request);
            //add
            var result = await _service.AddAsync(mapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}



