﻿using DigitalEducationServicec.Application.Features.Homework.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.Homework
{
    public partial class HomeworkProfile
    {
        public void GetHomeworkListMapping()
        {
            CreateMap<HomeworkTb, GetHomeworkListResponse>();

        }


    }
}
