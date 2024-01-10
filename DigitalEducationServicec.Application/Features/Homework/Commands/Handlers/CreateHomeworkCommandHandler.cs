using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Homework.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Homework.Commands.Handlers
{
    public class CreateHomeworkCommandHandler : ResponseHandler,
                                       IRequestHandler<AddHomeworkCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IHomeworkService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateHomeworkCommandHandler(IHomeworkService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(AddHomeworkCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and Homework
            var mapper = _mapper.Map<HomeworkTb>(request);
            //add
            var result = await _service.AddAsync(mapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}

