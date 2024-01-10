using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class TypesDiscountsTb
{
    public long TypesDiscountId { get; set; }

    public string? TypesDiscountName { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<AcademicDiscountTb> AcademicDiscountTbs { get; set; } = new List<AcademicDiscountTb>();
}
