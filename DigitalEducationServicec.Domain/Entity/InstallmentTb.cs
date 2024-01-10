using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class InstallmentTb
{
    public long InstallmentId { get; set; }

    public string? InstallmentName { get; set; }

    public DateTime? InstallmentDateSt { get; set; }

    public DateTime? InstallmentDateEnd { get; set; }

    public DateTime? InstallmentDueDate { get; set; }

    public decimal? InstallmentRate { get; set; }

    public long? TuitionFeeInstallmentId { get; set; }

    public virtual TuitionFeeInstallmentTb? TuitionFeeInstallment { get; set; }
}
