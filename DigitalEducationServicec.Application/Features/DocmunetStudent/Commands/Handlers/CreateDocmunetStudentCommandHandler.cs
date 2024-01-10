using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.DocmunetStudent.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.DocmunetStudent.Commands.Handlers
{
    public class CreateDocmunetStudentCommandHandler : ResponseHandler,
                                                      IRequestHandler<AddDocmunetStudentCommand, Response<string>>

    {
        #region Fields
        private readonly IMapper _mapper;
        private readonly IDocmunetStudentService _service;
        private readonly IStringLocalizer<SharedResources> _localizer;


        #endregion

        #region Constructors
        public CreateDocmunetStudentCommandHandler(IDocmunetStudentService service,
                                     IMapper mapper, IStringLocalizer<SharedResources> localizer) : base(localizer)

        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;

        }

        public async Task<Response<string>> Handle(AddDocmunetStudentCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and DocumentStudentTb
            var data = _mapper.Map<DocmunetStudentTb>(request);
            //add
            var result = await _service.AddAsync(data);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>();
        }
        #endregion

    }
}

