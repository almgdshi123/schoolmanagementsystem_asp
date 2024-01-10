using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.YearData.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.YearData.Commands.Handlers
{
    public class CreateYearDataCommandHandler : ResponseHandler,
                                       IRequestHandler<AddYearDataCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IYearDataService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public CreateYearDataCommandHandler(IYearDataService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(AddYearDataCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and ClassDataTb
            var data = _mapper.Map<YearDataTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
    }
}
