using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.ClassTuitionFees.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.ClassTuitionFees.Commands.Handlers
{

    public class CreateClassTuitionFeesCommandHandler : ResponseHandler,
                                           IRequestHandler<AddClassTuitionFeesCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IClassTuitionFeesService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateClassTuitionFeesCommandHandler(IClassTuitionFeesService service,
                                             IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddClassTuitionFeesCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and ClassTuitionFeesTb
            var data = _mapper.Map<ClassTuitionFeesTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }

}
