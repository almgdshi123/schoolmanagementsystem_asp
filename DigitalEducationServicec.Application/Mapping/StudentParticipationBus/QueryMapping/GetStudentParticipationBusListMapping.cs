﻿using DigitalEducationServicec.Application.Features.StudentParticipationBus.Queries.Results;
using DigitalEducationServicec.Domain.Entity;

namespace DigitalEducationServicec.Application.Mapping.StudentParticipationBus
{
    public partial class StudentParticipationBusProfile
    {
        public void GetStudentParticipationBusListMapping()
        {
            CreateMap<StudentParticipationBusTb, GetStudentParticipationBusListResponse>();
        }
    }
}
