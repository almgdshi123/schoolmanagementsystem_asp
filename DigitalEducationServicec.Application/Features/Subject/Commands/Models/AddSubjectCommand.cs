﻿using DigitalEducationServicec.Application.Bases;
using MediatR;

namespace DigitalEducationServicec.Application.Features.Subject.Commands.Models
{
    public class AddSubjectCommand : IRequest<Response<string>>
    {


        public string? SubjectNameArabic { get; set; }

        public string? SubjectNameEnglish { get; set; }

        public string? SubjectType { get; set; }

        public bool? SubjectIncludedInRate { get; set; }

        public decimal? LowScore { get; set; }

        public decimal? HighScore { get; set; }

        public string? Note { get; set; }

    }
}
