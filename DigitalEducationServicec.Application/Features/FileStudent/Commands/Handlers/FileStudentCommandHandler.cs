using AutoMapper;
using DigitalEducationServicec.Application.Bases;
using DigitalEducationServicec.Application.Features.FileStudent.Commands.Models;
using DigitalEducationServicec.Application.Resources;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Localization;

namespace DigitalEducationServicec.Application.Features.FileStudent.Commands.Handlers
{
    public class FileStudentCommandHandler : ResponseHandler,
                                       IRequestHandler<AddFileStudentCommand, Response<string>>,
                                       IRequestHandler<EditFileStudentCommand, Response<string>>,
                                       IRequestHandler<DeleteFileStudentCommand, Response<string>>
    {
        #region Fields
        private readonly IFileStudentService _service;
        private readonly IMapper _mapper;
        private readonly IStringLocalizer<SharedResources> _localizer;
        #endregion

        #region Constructors
        public FileStudentCommandHandler(IFileStudentService service,
                                     IMapper mapper,
                                     IStringLocalizer<SharedResources> localizer) : base(localizer)
        {
            _service = service;
            _mapper = mapper;
            _localizer = localizer;
        }
        #endregion


        public async Task<Response<string>> Handle(AddFileStudentCommand request, CancellationToken cancellationToken)
        {
            //mapping Between request and FileStudentTb
            var FileStudent = _mapper.Map<FileStudentTb>(request);
            //add
            var result = await _service.AddAsync(FileStudent);
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Created]);
            else return BadRequest<string>(_localizer[SharedResourcesKeys.BadRequest]);
        }


        public async Task<Response<string>> Handle(EditFileStudentCommand request, CancellationToken cancellationToken)
        {

            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.FileStudentId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //Call service that make Delete
            var result = await _service.DeleteAsync(data);
            if (result == "Success") return Deleted<string>(_localizer[SharedResourcesKeys.Deleted]);
            else return BadRequest<string>();
        }

        public async Task<Response<string>> Handle(DeleteFileStudentCommand request, CancellationToken cancellationToken)
        {
            //Check if the Id is Exist Or not
            var data = await _service.GetByIDAsync(request.FileStudentId);
            //return NotFound
            if (data == null) return NotFound<string>();
            //mapping Between request and data
            var datamapper = _mapper.Map(request, data);
            //Call service that make Edit
            var result = await _service.EditAsync(datamapper);
            //return response
            //return response
            if (result == "Success") return Success((string)_localizer[SharedResourcesKeys.Updated]);
            else return BadRequest<string>(_localizer[SharedResourcesKeys.Updated]);
        }
    }
}
