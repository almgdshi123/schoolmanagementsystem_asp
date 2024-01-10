﻿using DigitalEducationServicec.Application.Features.Teacher.Queries.Models;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Teacher
{
    public partial class TeacherProfile
    {
        public void GetTeacherByIDMapping()
        {
            CreateMap<TeacherTb, GetTeacherListQuery>();

        }
    }
}
