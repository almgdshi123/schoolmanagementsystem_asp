using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class TypesTuitionFeesTb
{
    public long TypesTuitionFeesId { get; set; }

    public string? TypesTuitionFeesName { get; set; }

    public bool? MonthlyService { get; set; }

    public bool? Installments { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<ClassTuitionFeesTb> ClassTuitionFeesTbs { get; set; } = new List<ClassTuitionFeesTb>();
}
