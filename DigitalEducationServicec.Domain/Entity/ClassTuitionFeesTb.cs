using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class ClassTuitionFeesTb
{
    public long ClassTuitionFeesId { get; set; }

    public string? ClassTuitionFeesName { get; set; }

    public string? ClassTuitionFeesType { get; set; }

    public long? TypesTuitionFeesId { get; set; }

    public decimal? Amount { get; set; }

    public long? ClassId { get; set; }

    public string? YearId { get; set; }

    public virtual ClassDataTb? Class { get; set; }

    public virtual ICollection<TuitionFeeInstallmentTb> TuitionFeeInstallmentTbs { get; set; } = new List<TuitionFeeInstallmentTb>();

    public virtual TypesTuitionFeesTb? TypesTuitionFees { get; set; }

    public virtual YearDataTb? Year { get; set; }
}
