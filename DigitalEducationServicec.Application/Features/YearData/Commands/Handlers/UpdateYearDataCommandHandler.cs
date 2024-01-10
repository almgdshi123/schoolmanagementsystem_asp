using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.YearData.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.YearData.Commands.Handlers
{
    public class UpdateYearDataCommandHandler : ResponseHandler,
                                       IRequestHandler<EditYearDataCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IYearDataService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public UpdateYearDataCommandHandler(IYearDataService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion


        public Task<Response<string>> Handle(EditYearDataCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            /*
                        //Check if the Id is Exist Or not
                        var data = await _service.GetByIDAsync(request.ClassId);
                        //return NotFound
                        if (data == null) return NotFound<string>();
                        //mapping Between request and data
                        var datamapper = _mapper.Map(request, data);
                        //Call service that make Edit
                        var result = await _service.EditAsync(datamapper);
                        //return response
                        //return response
                        if (result == "Success") return Success("تم التعديل");
                        else return BadRequest<string>();*/
        }
    }
}
