using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.Installment.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.Installment.Commands.Handlers
{
    public class CreateInstallmentCommandHandler : ResponseHandler,
                                                     IRequestHandler<AddInstallmentCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IInstallmentService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateInstallmentCommandHandler(IInstallmentService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddInstallmentCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and InstallmentTb
            var data = _mapper.Map<InstallmentTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}


