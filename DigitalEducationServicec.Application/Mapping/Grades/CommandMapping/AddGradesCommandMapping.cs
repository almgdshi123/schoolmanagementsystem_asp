﻿using DigitalEducationServicec.Application.Features.Grades.Commands.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Grades
{
    public partial class GradesProfile
    {
        public void AddGradesCommandMapping()
        {
            CreateMap<AddGradesCommand, GradesTb>();

        }
    }
}
