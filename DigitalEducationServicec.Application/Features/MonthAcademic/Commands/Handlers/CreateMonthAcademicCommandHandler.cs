using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.MonthAcademic.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.MonthAcademic.Commands.Handlers
{
    public class CreateMonthAcademicCommandHandler : ResponseHandler,
                                       IRequestHandler<AddMonthAcademicCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IMonthAcademicService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateMonthAcademicCommandHandler(IMonthAcademicService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddMonthAcademicCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and MonthAcademic
            var monthAcademicMapper = _mapper.Map<MonthAcademicTb>(request);
            //add
            var result = await _service.AddAsync(monthAcademicMapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}

