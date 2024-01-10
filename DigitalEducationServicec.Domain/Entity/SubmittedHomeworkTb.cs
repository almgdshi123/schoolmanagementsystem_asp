using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SubmittedHomeworkTb
{
    public long SubmittedHomeworkId { get; set; }

    public long? HomeworkId { get; set; }

    public long? FileStudentId { get; set; }

    public string? HomeworkTitle { get; set; }

    public string? HomeworkText { get; set; }

    public DateTime? SubmittedDate { get; set; }

    public int? Status { get; set; }

    public string? Note { get; set; }

    public virtual FileStudentTb? FileStudent { get; set; }

    public virtual HomeworkTb? Homework { get; set; }
}
