using DigitalEducationServicec.Application.Features.AcademicStatuses.Queries.Results;
using DigitalEducationServicec.Application.Features.Semesters.Commands.Models;
using DigitalEducationServicec.Application.Features.Semesters.Queries.Results;
using DigitalEducationServicec.Application.Features.Student.Queries.Results;
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
            public void GetSemesterListMapping()
            {
                CreateMap<SemesterTb, GetSemesterListResponse>();
            }
        }
    }