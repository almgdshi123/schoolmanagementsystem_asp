using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionClassSub.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DistributionClassSub.Commands.Handlers
{
    public class CreateDistributionClassSubCommandHandler : ResponseHandler,
                                       IRequestHandler<AddDistributionClassSubCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        private readonly IDistributionClassSubService _service;

        #endregion

        #region Constructors
        public CreateDistributionClassSubCommandHandler(IDistributionClassSubService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(AddDistributionClassSubCommand request, CancellationToken cancellationToken)
        {

            //mapping Between request and DistributionClassSub
            var DistributionClassSub = _mapper.Map<DistributionClassSubTb>(request);
            //add
            var result = await _service.AddAsync(DistributionClassSub);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>(_localizer[SharedResourcesKeys.BadRequest]);
        }


    }
}
