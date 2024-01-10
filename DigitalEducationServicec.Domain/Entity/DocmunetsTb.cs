using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DocmunetsTb
{
    public long DocmunetId { get; set; }

    public string DocmunetName { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual ICollection<DocmunetsClassTb> DocmunetsClassTbs { get; set; } = new List<DocmunetsClassTb>();
}
