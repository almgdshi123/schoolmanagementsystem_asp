using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class MonthTb
{
    public long MonthId { get; set; }

    public string? MonthName { get; set; }

    public int? MonthNumber { get; set; }

    public int? Status { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<MonthAcademicTb> MonthAcademicTbs { get; set; } = new List<MonthAcademicTb>();
}
