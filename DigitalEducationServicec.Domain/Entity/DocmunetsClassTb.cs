using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DocmunetsClassTb
{
    public long DocmunetsClassId { get; set; }

    public long DocmunetId { get; set; }

    public long ClassId { get; set; }

    public string DocmunetName { get; set; } = null!;

    public string? Notes { get; set; }

    public virtual ClassDataTb Class { get; set; } = null!;

    public virtual DocmunetsTb Docmunet { get; set; } = null!;

    public virtual ICollection<DocmunetStudentTb> DocmunetStudentTbs { get; set; } = new List<DocmunetStudentTb>();
}
