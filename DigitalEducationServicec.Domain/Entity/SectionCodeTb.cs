using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SectionCodeTb
{
    public long SectionCodeId { get; set; }

    public string? SectionCodeName { get; set; }

    public string? SectionCodeCode { get; set; }

    public virtual ICollection<SectionDataTb> SectionDataTbs { get; set; } = new List<SectionDataTb>();
}
