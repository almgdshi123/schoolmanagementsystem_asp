using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class TypeOfActivitiesTb
{
    public long TypeOfActivitieId { get; set; }

    public string? TypeOfActivitieName { get; set; }

    public string? Note { get; set; }

    public virtual ICollection<StudentActivitieTb> StudentActivitieTbs { get; set; } = new List<StudentActivitieTb>();
}
