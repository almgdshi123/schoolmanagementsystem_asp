using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class StreetsTb
{
    public long StreetId { get; set; }

    public string? StreetName { get; set; }

    public long? TrafficLineId { get; set; }

    public string? Notes { get; set; }

    public virtual ICollection<DistributionOfBuseStreetTb> DistributionOfBuseStreetTbs { get; set; } = new List<DistributionOfBuseStreetTb>();
}
