using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class TuitionFeeInstallmentTb
{
    public long TuitionFeeInstallmentId { get; set; }

    public string? TuitionFeeInstallmentName { get; set; }

    public DateTime? DateFristInstallment { get; set; }

    public int? AlertPeriodPerDay { get; set; }

    public long? ClassTuitionFeesId { get; set; }

    public int? TuitionFeeInstallmentCount { get; set; }

    public string? YearId { get; set; }

    public virtual ClassTuitionFeesTb? ClassTuitionFees { get; set; }

    public virtual ICollection<InstallmentTb> InstallmentTbs { get; set; } = new List<InstallmentTb>();

    public virtual YearDataTb? Year { get; set; }
}
