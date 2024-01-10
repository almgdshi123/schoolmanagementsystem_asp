using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DistributionOfBuseStreet.Commands.Handlers
{
    public class CreateDistributionOfBuseStreetCommandHandler : ResponseHandler,
                                             IRequestHandler<AddDistributionOfBuseStreetCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IDistributionOfBuseStreetService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateDistributionOfBuseStreetCommandHandler(IDistributionOfBuseStreetService service,
                                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddDistributionOfBuseStreetCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and DistributionOfBuseStreetTb
            var data = _mapper.Map<DistributionOfBuseStreetTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}


