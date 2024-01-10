using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Fines.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Fines.Commands.Handlers
{
    public class CreateFinesCommandHandler : ResponseHandler,
                                                     IRequestHandler<AddFinesCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IFinesService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateFinesCommandHandler(IFinesService service,
                                         IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddFinesCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and FinesTb
            var data = _mapper.Map<FinesTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}