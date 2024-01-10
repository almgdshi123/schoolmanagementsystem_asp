using System;
using System.Collections.Generic;

namespace DigitalEducationServicec.Domain.Entity;

public partial class YearDataTb
{
    public string YearId { get; set; } = null!;

    public string? YearName { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Status { get; set; }

    public virtual ICollection<AcademicDiscountTb> AcademicDiscountTbs { get; set; } = new List<AcademicDiscountTb>();

    public virtual ICollection<ClassTuitionFeesTb> ClassTuitionFeesTbs { get; set; } = new List<ClassTuitionFeesTb>();

    public virtual ICollection<DistributionOfBuseStreetTb> DistributionOfBuseStreetTbs { get; set; } = new List<DistributionOfBuseStreetTb>();

    public virtual ICollection<FileStudentTb> FileStudentTbs { get; set; } = new List<FileStudentTb>();

    public virtual ICollection<FinesTb> FinesTbs { get; set; } = new List<FinesTb>();

    public virtual ICollection<SemesterAcademicTb> SemesterAcademicTbs { get; set; } = new List<SemesterAcademicTb>();

    public virtual ICollection<TuitionFeeInstallmentTb> TuitionFeeInstallmentTbs { get; set; } = new List<TuitionFeeInstallmentTb>();

    public virtual ICollection<VacationsTb> VacationsTbs { get; set; } = new List<VacationsTb>();
}
