using AutoMapper;
using DigitalEducationServicec.Application.Features.Semesters.Commands.CreateSemester;
using DigitalEducationServicec.Application.Features.Semesters.Queries.GetSemesterList;
using DigitalEducationServicec.Domain.Entity;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Profiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<SemesterTb, SemesterViewModel>().ReverseMap();
            CreateMap<SemesterTb, CreateSemesterCommand>().ReverseMap();


        }
    }
}
