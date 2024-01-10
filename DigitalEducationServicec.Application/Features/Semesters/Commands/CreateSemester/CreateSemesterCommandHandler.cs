using AutoMapper;
using Azure;
using Azure.Core;
using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Servicec.Abstraction;
using MediatR;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DigitalEducationServicec.Application.Features.Semesters.Commands.CreateSemester
{
    public class CreateSemesterCommandHandler : IRequestHandler<CreateSemesterCommand, string>
    {
        private readonly IMapper _mapper;
        private readonly ISemesterService _semesterService;

        public CreateSemesterCommandHandler(IMapper mapper, ISemesterService semesterService)
        {
            _mapper = mapper;
            _semesterService = semesterService;

        }

        //    public async Task<Response<string> Handle(CreateSemesterCommand request, CancellationToken cancellationToken)
        //    {

        //   
        //}

        public async Task<string> Handle(CreateSemesterCommand request, CancellationToken cancellationToken)
        {
            SemesterTb post = _mapper.Map<SemesterTb>(request);
            CreateSemesterValidator validator = new CreateSemesterValidator();
            var result = await validator.ValidateAsync(request);

            if (result.Errors.Any())
            {
                //   throw new Exception("Post is not valid");
                return "Post is not valid";
            }
            var re = await _semesterService.AddAsync(post);
            //return response
            if (re == "Success") return "Success";
            else return "not";
        }
    }
}