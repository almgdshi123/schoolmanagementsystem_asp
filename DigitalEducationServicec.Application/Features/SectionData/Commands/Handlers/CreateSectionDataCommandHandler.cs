using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SectionData.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SectionData.Commands.Handlers
{
    public class CreateSectionDataCommandHandler : ResponseHandler,
                                       IRequestHandler<AddSectionDataCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISectionDataService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateSectionDataCommandHandler(ISectionDataService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public async Task<Response<string>> Handle(AddSectionDataCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and SectionData
            var sectionDataMapper = _mapper.Map<SectionDataTb>(request);
            //add
            var result = await _service.AddAsync(sectionDataMapper);
            //return response
            if (result == "Success") return Created("");
            else return BadRequest<string>();
        }
    }
}
