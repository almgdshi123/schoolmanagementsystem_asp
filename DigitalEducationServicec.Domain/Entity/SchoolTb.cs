using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class SchoolTb
{
    public long SchoolId { get; set; }

    public string? SchoolName { get; set; }

    public long? SchoolGroupId { get; set; }

    public string? SchoolAddress { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? SchoolPrincipal { get; set; }

    public virtual SchoolGroupTb? SchoolGroup { get; set; }
}
