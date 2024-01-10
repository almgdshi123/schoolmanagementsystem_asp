using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class ParentTb
{
    public long ParentId { get; set; }

    public string? ParentName { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Address { get; set; }

    public string? Gender { get; set; }

    public long? UserId { get; set; }

    public decimal? NationalId { get; set; }

    public string? NationalType { get; set; }

    public DateTime? ReleaseDate { get; set; }

    public string? JopTitle { get; set; }

    public DateTime? BirthDate { get; set; }

    public virtual ICollection<StudentsParentRelTb> StudentsParentRelTbs { get; set; } = new List<StudentsParentRelTb>();

    public virtual UserDataTb? User { get; set; }
}
