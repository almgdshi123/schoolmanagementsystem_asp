using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class AcademicDiscountTb
{
    public long AcademicDiscountId { get; set; }

    public string? AcademicDiscountName { get; set; }

    public string? AcademicDiscountType { get; set; }

    public decimal? AmountDiscount { get; set; }

    public long? TypesDiscountId { get; set; }

    public string? YearId { get; set; }

    public virtual TypesDiscountsTb? TypesDiscount { get; set; }

    public virtual YearDataTb? Year { get; set; }
}
