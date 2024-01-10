using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.SectionCode.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.SectionCode.Commands.Handlers
{
    public class CreateSectionCodeCommandHandler : ResponseHandler,
                                                      IRequestHandler<AddSectionCodeCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ISectionCodeService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateSectionCodeCommandHandler(ISectionCodeService service,
                                                 IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddSectionCodeCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and SectionCodeTb
            var data = _mapper.Map<SectionCodeTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}