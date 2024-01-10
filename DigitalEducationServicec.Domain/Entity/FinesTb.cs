using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class FinesTb
{
    public long FinesId { get; set; }

    public string? FinesName { get; set; }

    public decimal? FinesAmount { get; set; }

    public string? Status { get; set; }

    public string? YearId { get; set; }

    public virtual YearDataTb? Year { get; set; }
}
