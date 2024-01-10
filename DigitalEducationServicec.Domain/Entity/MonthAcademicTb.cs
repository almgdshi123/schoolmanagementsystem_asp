using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class MonthAcademicTb
{
    public long MonthAcademicId { get; set; }

    public string? Note { get; set; }

    public long? MonthId { get; set; }

    public long? SemesterAcademicId { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<GradesMonthTb> GradesMonthTbs { get; set; } = new List<GradesMonthTb>();

    public virtual ICollection<HomeworkTb> HomeworkTbs { get; set; } = new List<HomeworkTb>();

    public virtual MonthTb? Month { get; set; }

    public virtual ICollection<PreparationTb> PreparationTbs { get; set; } = new List<PreparationTb>();

    public virtual SemesterAcademicTb? SemesterAcademic { get; set; }
}
