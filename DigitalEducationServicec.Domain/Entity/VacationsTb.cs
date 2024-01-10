using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class VacationsTb
{
    public long VacationId { get; set; }

    public string? VacationName { get; set; }

    public DateTime? VacationDateSt { get; set; }

    public DateTime? VacationDateEnd { get; set; }

    public string? YearId { get; set; }

    public string? VacationType { get; set; }

    public virtual YearDataTb? Year { get; set; }
}
