using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Month.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Month.Commands.Handlers
{
    public class CreateMonthCommandHandler : ResponseHandler,
                                       IRequestHandler<AddMonthCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IMonthService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateMonthCommandHandler(IMonthService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddMonthCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and Month
            var monthMapper = _mapper.Map<MonthTb>(request);
            //add
            var result = await _service.AddAsync(monthMapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}

