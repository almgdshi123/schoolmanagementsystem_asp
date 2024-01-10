using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Commands.Handlers
{
    public class CreateTuitionFeeInstallmentCommandHandler : ResponseHandler,
                                                    IRequestHandler<AddTuitionFeeInstallmentCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ITuitionFeeInstallmentService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateTuitionFeeInstallmentCommandHandler(ITuitionFeeInstallmentService service,
                                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddTuitionFeeInstallmentCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and TuitionFeeInstallmentTb
            var data = _mapper.Map<TuitionFeeInstallmentTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
