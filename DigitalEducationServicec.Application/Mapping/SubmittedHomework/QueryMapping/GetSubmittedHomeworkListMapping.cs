﻿using DigitalEducationServicec.Application.Features.SubmittedHomework.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.SubmittedHomework
{
    public partial class SubmittedHomeworkProfile
    {
        public void GetSubmittedHomeworkListMapping()
        {
            CreateMap<SubmittedHomeworkTb, GetSubmittedHomeworkListResponse>();

        }

    }
}
