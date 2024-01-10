using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.YearData.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.YearData.Commands.Handlers
{
    public class DeleteYearDataCommandHandler : ResponseHandler,
                                       IRequestHandler<DeleteYearDataCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IYearDataService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public DeleteYearDataCommandHandler(IYearDataService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }
        #endregion

        public Task<Response<string>> Handle(DeleteYearDataCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
            /*  //Check if the Id is Exist Or not
          var data = await _service.GetByIDAsync(request.);
          //return NotFound
          if (data == null) return NotFound<string>();
          //Call service that make Delete
          var result = await _service.DeleteAsync(data);
          if (result == "Success") return Deleted<string>();
          else return BadRequest<string>();*/
        }
    }
}
