using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DistributionSubTeacherTb
{
    public long DistrSubTeacherId { get; set; }

    public long DistrClassSubId { get; set; }

    public long TeacherId { get; set; }

    public long SemesterAcademicId { get; set; }

    public DateTime? DistrDate { get; set; }

    public int? Status { get; set; }

    public string? Note { get; set; }

    public virtual DistributionClassSubTb DistrClassSub { get; set; } = null!;

    public virtual ICollection<GradesMonthTb> GradesMonthTbs { get; set; } = new List<GradesMonthTb>();

    public virtual ICollection<GradesSemesterTb> GradesSemesterTbs { get; set; } = new List<GradesSemesterTb>();

    public virtual ICollection<HomeworkTb> HomeworkTbs { get; set; } = new List<HomeworkTb>();

    public virtual ICollection<PreparationTb> PreparationTbs { get; set; } = new List<PreparationTb>();

    public virtual TeacherTb Teacher { get; set; } = null!;
}
