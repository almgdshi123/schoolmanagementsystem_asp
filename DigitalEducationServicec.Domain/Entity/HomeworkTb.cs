using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class HomeworkTb
{
    public long HomeworkId { get; set; }

    public long DistrSubTeacherId { get; set; }

    public string? HomeworkTitle { get; set; }

    public string? HomeworkText { get; set; }

    public DateTime? SubmissionDate { get; set; }

    public long? MonthAcademicId { get; set; }

    public int? Status { get; set; }

    public string? Note { get; set; }

    public virtual DistributionSubTeacherTb DistrSubTeacher { get; set; } = null!;

    public virtual MonthAcademicTb? MonthAcademic { get; set; }

    public virtual ICollection<SubmittedHomeworkTb> SubmittedHomeworkTbs { get; set; } = new List<SubmittedHomeworkTb>();
}
