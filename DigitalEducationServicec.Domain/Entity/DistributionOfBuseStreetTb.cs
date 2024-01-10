using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DistributionOfBuseStreetTb
{
    public long DistributionOfBuseStreetId { get; set; }

    public long? StreetId { get; set; }

    public long? BusId { get; set; }

    public DateTime? DistributionDate { get; set; }

    public string? YearId { get; set; }

    public virtual BusTb? Bus { get; set; }

    public virtual StreetsTb? Street { get; set; }

    public virtual YearDataTb? Year { get; set; }
}
