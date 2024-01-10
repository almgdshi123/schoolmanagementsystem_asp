using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SemesterAcademicTb
{
    public long SemesterAcademicId { get; set; }

    public long SemesterId { get; set; }

    public string YearId { get; set; } = null!;

    public int? Status { get; set; }

    public string? Note { get; set; }

    public string? SemesterAcademicTitel { get; set; }

    public string? SemesterAcademicType { get; set; }

    public virtual ICollection<GradesSemesterTb> GradesSemesterTbs { get; set; } = new List<GradesSemesterTb>();

    public virtual ICollection<MonthAcademicTb> MonthAcademicTbs { get; set; } = new List<MonthAcademicTb>();

    public virtual SemesterTb Semester { get; set; } = null!;

    public virtual YearDataTb Year { get; set; } = null!;
}
