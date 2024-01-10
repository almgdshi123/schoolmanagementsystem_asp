using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.AcademicDiscount.Commands.Handlers
{
    public class UpdateAcademicDiscountCommandHandler : ResponseHandler,
                                       IRequestHandler<EditAcademicDiscountCommand, Response<string>>
    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IAcademicDiscountService _service;

        #endregion
        private readonly IStringLocalizer<SharedResources> _localizer;



        #region Constructors
        public UpdateAcademicDiscountCommandHandler(IAcademicDiscountService service,
                                           IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public async Task<Response<string>> Handle(EditAcademicDiscountCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.AcademicDiscountId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //mapping Between request and data
            var datamapper = _mapper.Map(request, data);
            //Call service that make Edit
            var result = await _service.EditAsync(datamapper);
            //return response
            //return response
            if (result == "Success") return Success("تم التعديل");
            else return BadRequest<string>();
        }
    }
}
