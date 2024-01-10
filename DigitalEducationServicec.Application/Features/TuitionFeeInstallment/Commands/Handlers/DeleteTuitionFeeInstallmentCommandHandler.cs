using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.TuitionFeeInstallment.Commands.Handlers
{
    public class DeleteTuitionFeeInstallmentCommandHandler : ResponseHandler,
                                                      IRequestHandler<DeleteTuitionFeeInstallmentCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly ITuitionFeeInstallmentService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public DeleteTuitionFeeInstallmentCommandHandler(ITuitionFeeInstallmentService service,
                                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        #endregion


        public async Task<Response<string>> Handle(DeleteTuitionFeeInstallmentCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.TuitionFeeInstallmentId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>();
            else return BadRequest<string>();
        }
    }
}
