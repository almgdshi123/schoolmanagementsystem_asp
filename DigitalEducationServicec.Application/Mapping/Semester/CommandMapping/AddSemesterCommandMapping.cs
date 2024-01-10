using DigitalEducationServicec.Application.Features.Semesters.Commands.Models;
using DigitalEducationServicec.Application.Features.Student.Commands.Models;
using DigitalEducationServicec.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalEducationServicec.Application.Mapping.Semester
{
    public partial class SemesterProfile
    {
        public void AddSemesterCommandMapping()
        {
            CreateMap<AddSemesterCommand, SemesterTb>();
            
        }
    }
}