using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class GradesTb
{
    public long GradesTypeId { get; set; }

    public string? GradesName { get; set; }

    public string? GradesType { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<GradesMonthTb> GradesMonthTbs { get; set; } = new List<GradesMonthTb>();

    public virtual ICollection<GradesSemesterTb> GradesSemesterTbs { get; set; } = new List<GradesSemesterTb>();
}
