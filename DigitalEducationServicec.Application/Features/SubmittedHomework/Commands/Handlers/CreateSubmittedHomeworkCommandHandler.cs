using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SubmittedHomework.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SubmittedHomework.Commands.Handlers
{
    public class CreateSubmittedHomeworkCommandHandler : ResponseHandler,
                                       IRequestHandler<AddSubmittedHomeworkCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISubmittedHomeworkService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateSubmittedHomeworkCommandHandler(ISubmittedHomeworkService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(AddSubmittedHomeworkCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and SubmittedHomework
            var data = _mapper.Map<SubmittedHomeworkTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
    }
}
