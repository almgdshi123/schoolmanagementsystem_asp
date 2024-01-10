using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Handlers
{
    public class CreateAcademicDiscountCommandHandler : ResponseHandler,
                                       IRequestHandler<AddAcademicDiscountCommand, Response<string>>
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IAcademicDiscountService _service;

        #endregion
        private readonly IStringLocalizer<SharedResources> _localizer;



        #region Constructors
        public CreateAcademicDiscountCommandHandler(IAcademicDiscountService service,
                                           IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddAcademicDiscountCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and ClassDataTb
            var data = _mapper.Map<AcademicDiscountTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}
