using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DigitalEducationServicec.Domain.Entity;

public partial class DigitalEducationServiceDbnContext : DbContext
{
    public DigitalEducationServiceDbnContext()
    {
    }

    public DigitalEducationServiceDbnContext(DbContextOptions<DigitalEducationServiceDbnContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AcademicDiscountTb> AcademicDiscountTbs { get; set; }

    public virtual DbSet<AcademicStatusesTb> AcademicStatusesTbs { get; set; }

    public virtual DbSet<AcademicSystemsTb> AcademicSystemsTbs { get; set; }

    public virtual DbSet<AppreciationTb> AppreciationTbs { get; set; }

    public virtual DbSet<BusTb> BusTbs { get; set; }

    public virtual DbSet<ClassDataTb> ClassDataTbs { get; set; }

    public virtual DbSet<ClassTuitionFeesTb> ClassTuitionFeesTbs { get; set; }

    public virtual DbSet<DayDataTb> DayDataTbs { get; set; }

    public virtual DbSet<DistributionClassSubTb> DistributionClassSubTbs { get; set; }

    public virtual DbSet<DistributionOfBuseStreetTb> DistributionOfBuseStreetTbs { get; set; }

    public virtual DbSet<DistributionSubTeacherTb> DistributionSubTeacherTbs { get; set; }

    public virtual DbSet<DocmunetStudentTb> DocmunetStudentTbs { get; set; }

    public virtual DbSet<DocmunetsClassTb> DocmunetsClassTbs { get; set; }

    public virtual DbSet<DocmunetsTb> DocmunetsTbs { get; set; }

    public virtual DbSet<FileStudentTb> FileStudentTbs { get; set; }

    public virtual DbSet<FinesTb> FinesTbs { get; set; }

    public virtual DbSet<GradesMonthTb> GradesMonthTbs { get; set; }

    public virtual DbSet<GradesSemesterTb> GradesSemesterTbs { get; set; }

    public virtual DbSet<GradesTb> GradesTbs { get; set; }

    public virtual DbSet<HomeworkTb> HomeworkTbs { get; set; }

    public virtual DbSet<InstallmentTb> InstallmentTbs { get; set; }

    public virtual DbSet<JopTypeTb> JopTypeTbs { get; set; }

    public virtual DbSet<MonthAcademicTb> MonthAcademicTbs { get; set; }

    public virtual DbSet<MonthTb> MonthTbs { get; set; }

    public virtual DbSet<ParentTb> ParentTbs { get; set; }

    public virtual DbSet<ParticiStudentActivTb> ParticiStudentActivTbs { get; set; }

    public virtual DbSet<PreparationTb> PreparationTbs { get; set; }

    public virtual DbSet<QualificationTb> QualificationTbs { get; set; }

    public virtual DbSet<SchoolGroupTb> SchoolGroupTbs { get; set; }

    public virtual DbSet<SchoolTb> SchoolTbs { get; set; }

    public virtual DbSet<SectionCodeTb> SectionCodeTbs { get; set; }

    public virtual DbSet<SectionDataTb> SectionDataTbs { get; set; }

    public virtual DbSet<SemesterAcademicTb> SemesterAcademicTbs { get; set; }

    public virtual DbSet<SemesterTb> SemesterTbs { get; set; }

    public virtual DbSet<SpecializationTb> SpecializationTbs { get; set; }

    public virtual DbSet<StageTb> StageTbs { get; set; }

    public virtual DbSet<StreetsTb> StreetsTbs { get; set; }

    public virtual DbSet<StudentActivitieTb> StudentActivitieTbs { get; set; }

    public virtual DbSet<StudentParticipationBusTb> StudentParticipationBusTbs { get; set; }

    public virtual DbSet<StudentTb> StudentTbs { get; set; }

    public virtual DbSet<StudentsParentRelTb> StudentsParentRelTbs { get; set; }

    public virtual DbSet<SubjectTb> SubjectTbs { get; set; }

    public virtual DbSet<SubmittedHomeworkTb> SubmittedHomeworkTbs { get; set; }

    public virtual DbSet<TeacherTb> TeacherTbs { get; set; }

    public virtual DbSet<TrafficLineTb> TrafficLineTbs { get; set; }

    public virtual DbSet<TuitionFeeInstallmentTb> TuitionFeeInstallmentTbs { get; set; }

    public virtual DbSet<TypeOfActivitiesTb> TypeOfActivitiesTbs { get; set; }

    public virtual DbSet<TypesDiscountsTb> TypesDiscountsTbs { get; set; }

    public virtual DbSet<TypesTuitionFeesTb> TypesTuitionFeesTbs { get; set; }

    public virtual DbSet<UserDataTb> UserDataTbs { get; set; }

    public virtual DbSet<VacationsTb> VacationsTbs { get; set; }

    public virtual DbSet<YearDataTb> YearDataTbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=LAPTOP-OVDOKS25;Database=DigitalEducationServiceDBN;User ID = erb; password=1234;Trusted_Connection=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AcademicDiscountTb>(entity =>
        {
            entity.HasKey(e => e.AcademicDiscountId);

            entity.ToTable("AcademicDiscountTB");

            entity.Property(e => e.AcademicDiscountName).HasMaxLength(50);
            entity.Property(e => e.AcademicDiscountType).HasMaxLength(50);
            entity.Property(e => e.AmountDiscount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.TypesDiscount).WithMany(p => p.AcademicDiscountTbs)
                .HasForeignKey(d => d.TypesDiscountId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_AcademicDiscountTB_TypesDiscountsTB");

            entity.HasOne(d => d.Year).WithMany(p => p.AcademicDiscountTbs)
                .HasForeignKey(d => d.YearId)
                .HasConstraintName("FK_AcademicDiscountTB_YearDataTB");
        });

        modelBuilder.Entity<AcademicStatusesTb>(entity =>
        {
            entity.HasKey(e => e.StatusId).HasName("PK__Academic__C8EE2063A6FFF9F3");

            entity.ToTable("AcademicStatusesTB");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.StatusName).HasMaxLength(255);
        });

        modelBuilder.Entity<AcademicSystemsTb>(entity =>
        {
            entity.HasKey(e => e.SystemId).HasName("PK__Academic__9394F68AB93E5E25");

            entity.ToTable("AcademicSystemsTB");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.SystemName).HasMaxLength(255);
        });

        modelBuilder.Entity<AppreciationTb>(entity =>
        {
            entity.HasKey(e => e.AppreciationId);

            entity.ToTable("AppreciationTB");

            entity.Property(e => e.AppreciationName).HasMaxLength(50);
            entity.Property(e => e.AppreciationNameEn).HasMaxLength(50);
            entity.Property(e => e.HighScore).HasMaxLength(100);
            entity.Property(e => e.LowScore).HasMaxLength(100);
        });

        modelBuilder.Entity<BusTb>(entity =>
        {
            entity.HasKey(e => e.BusId);

            entity.ToTable("BusTB");

            entity.Property(e => e.Address).HasMaxLength(100);
            entity.Property(e => e.BusDriverName).HasMaxLength(100);
            entity.Property(e => e.BusType).HasMaxLength(100);
            entity.Property(e => e.HelperName).HasMaxLength(100);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.Phone).HasMaxLength(100);
            entity.Property(e => e.PlateNumber).HasMaxLength(100);
            entity.Property(e => e.SupervisorName).HasMaxLength(100);
            entity.Property(e => e.TimeAttendance).HasColumnType("datetime");
            entity.Property(e => e.TimeLeave).HasColumnType("datetime");
        });

        modelBuilder.Entity<ClassDataTb>(entity =>
        {
            entity.HasKey(e => e.ClassId).HasName("PK__ClassDat__CB1927C03DDB60ED");

            entity.ToTable("ClassDataTB");

            entity.Property(e => e.ClassCode).HasMaxLength(50);
            entity.Property(e => e.ClassName).HasMaxLength(255);

            entity.HasOne(d => d.Stage).WithMany(p => p.ClassDataTbs)
                .HasForeignKey(d => d.StageId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClassData_Stage");
        });

        modelBuilder.Entity<ClassTuitionFeesTb>(entity =>
        {
            entity.HasKey(e => e.ClassTuitionFeesId);

            entity.ToTable("ClassTuitionFeesTB");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ClassTuitionFeesName).HasMaxLength(50);
            entity.Property(e => e.ClassTuitionFeesType).HasMaxLength(50);
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.Class).WithMany(p => p.ClassTuitionFeesTbs)
                .HasForeignKey(d => d.ClassId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClassTuitionFeesTB_ClassDataTB");

            entity.HasOne(d => d.TypesTuitionFees).WithMany(p => p.ClassTuitionFeesTbs)
                .HasForeignKey(d => d.TypesTuitionFeesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClassTuitionFeesTB_TypesTuitionFeesTB");

            entity.HasOne(d => d.Year).WithMany(p => p.ClassTuitionFeesTbs)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ClassTuitionFeesTB_YearDataTB");
        });

        modelBuilder.Entity<DayDataTb>(entity =>
        {
            entity.HasKey(e => e.DayId).HasName("PK_DayData");

            entity.ToTable("DayDataTB");

            entity.Property(e => e.DayName).HasMaxLength(50);
            entity.Property(e => e.Notes).HasMaxLength(50);
        });

        modelBuilder.Entity<DistributionClassSubTb>(entity =>
        {
            entity.HasKey(e => e.DistrClassSubId).HasName("PK__Distribu__53D89ABC44B00B80");

            entity.ToTable("DistributionClassSubTB");

            entity.Property(e => e.ClassCode).HasMaxLength(50);
            entity.Property(e => e.Note).HasMaxLength(255);

            entity.HasOne(d => d.Class).WithMany(p => p.DistributionClassSubTbs)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_DistributionClassSub_ClassData");

            entity.HasOne(d => d.Subject).WithMany(p => p.DistributionClassSubTbs)
                .HasForeignKey(d => d.SubjectId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DistributionClassSub_Subject");
        });

        modelBuilder.Entity<DistributionOfBuseStreetTb>(entity =>
        {
            entity.HasKey(e => e.DistributionOfBuseStreetId);

            entity.ToTable("DistributionOfBuseStreetTB");

            entity.Property(e => e.DistributionDate).HasColumnType("date");
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.Bus).WithMany(p => p.DistributionOfBuseStreetTbs)
                .HasForeignKey(d => d.BusId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DistributionOfBuseStreetTB_BusTB");

            entity.HasOne(d => d.Street).WithMany(p => p.DistributionOfBuseStreetTbs)
                .HasForeignKey(d => d.StreetId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DistributionOfBuseStreetTB_StreetsTB");

            entity.HasOne(d => d.Year).WithMany(p => p.DistributionOfBuseStreetTbs)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_DistributionOfBuseStreetTB_YearDataTB");
        });

        modelBuilder.Entity<DistributionSubTeacherTb>(entity =>
        {
            entity.HasKey(e => e.DistrSubTeacherId).HasName("PK__Distribu__B6E2464D4DA5AE0D");

            entity.ToTable("DistributionSubTeacherTB");

            entity.Property(e => e.DistrDate).HasColumnType("date");
            entity.Property(e => e.Note).HasMaxLength(255);

            entity.HasOne(d => d.DistrClassSub).WithMany(p => p.DistributionSubTeacherTbs)
                .HasForeignKey(d => d.DistrClassSubId)
                .HasConstraintName("FK_DistributionSubTeacher_DistributionClassSub");

            entity.HasOne(d => d.Teacher).WithMany(p => p.DistributionSubTeacherTbs)
                .HasForeignKey(d => d.TeacherId)
                .HasConstraintName("FK_DistributionSubTeacher_Teacher");
        });

        modelBuilder.Entity<DocmunetStudentTb>(entity =>
        {
            entity.HasKey(e => e.DocmunetStudentId).HasName("PK_DocmunetStudent");

            entity.ToTable("DocmunetStudentTB");

            entity.Property(e => e.DocmunetStatus).HasMaxLength(150);
            entity.Property(e => e.DocmunetType).HasMaxLength(150);

            entity.HasOne(d => d.DocmunetsClass).WithMany(p => p.DocmunetStudentTbs)
                .HasForeignKey(d => d.DocmunetsClassId)
                .HasConstraintName("FK_DocmunetStudentTB_DocmunetsClassTB");

            entity.HasOne(d => d.FileStudent).WithMany(p => p.DocmunetStudentTbs)
                .HasForeignKey(d => d.FileStudentId)
                .HasConstraintName("FK_DocmunetStudentTB_FileStudentTB");
        });

        modelBuilder.Entity<DocmunetsClassTb>(entity =>
        {
            entity.HasKey(e => e.DocmunetsClassId).HasName("PK_DocmunetClass");

            entity.ToTable("DocmunetsClassTB");

            entity.Property(e => e.DocmunetName).HasMaxLength(150);

            entity.HasOne(d => d.Class).WithMany(p => p.DocmunetsClassTbs)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_DocmunetsClassTB_ClassDataTB");

            entity.HasOne(d => d.Docmunet).WithMany(p => p.DocmunetsClassTbs)
                .HasForeignKey(d => d.DocmunetId)
                .HasConstraintName("FK_DocmunetsClassTB_DocmunetsTB");
        });

        modelBuilder.Entity<DocmunetsTb>(entity =>
        {
            entity.HasKey(e => e.DocmunetId).HasName("PK_Docmunets");

            entity.ToTable("DocmunetsTB");

            entity.Property(e => e.DocmunetName).HasMaxLength(150);
        });

        modelBuilder.Entity<FileStudentTb>(entity =>
        {
            entity.HasKey(e => e.FileStudentId).HasName("PK__FileStud__E2419B2928932643");

            entity.ToTable("FileStudentTB");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.RenewalDate).HasColumnType("date");
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.Section).WithMany(p => p.FileStudentTbs)
                .HasForeignKey(d => d.SectionId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FileStudent_SectionData");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.FileStudentTbs)
                .HasForeignKey(d => d.StatusId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FileStudent_Student");

            entity.HasOne(d => d.Year).WithMany(p => p.FileStudentTbs)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FileStudent_FileStudent");
        });

        modelBuilder.Entity<FinesTb>(entity =>
        {
            entity.HasKey(e => e.FinesId);

            entity.ToTable("FinesTB");

            entity.Property(e => e.FinesAmount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinesName).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.Year).WithMany(p => p.FinesTbs)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_FinesTB_YearDataTB");
        });

        modelBuilder.Entity<GradesMonthTb>(entity =>
        {
            entity.HasKey(e => e.GradesMonthId).HasName("PK__GradesMo__55FA67AA440F3474");

            entity.ToTable("GradesMonthTB");

            entity.Property(e => e.GradesText).HasMaxLength(255);
            entity.Property(e => e.GradesValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Note).HasMaxLength(255);

            entity.HasOne(d => d.DistrSubTeacher).WithMany(p => p.GradesMonthTbs)
                .HasForeignKey(d => d.DistrSubTeacherId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GradesMonth_DistributionSubTeacher");

            entity.HasOne(d => d.FileStudent).WithMany(p => p.GradesMonthTbs)
                .HasForeignKey(d => d.FileStudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GradesMonth_FileStudent");

            entity.HasOne(d => d.GradesType).WithMany(p => p.GradesMonthTbs)
                .HasForeignKey(d => d.GradesTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GradesMonth_Grades");

            entity.HasOne(d => d.MonthAcademic).WithMany(p => p.GradesMonthTbs)
                .HasForeignKey(d => d.MonthAcademicId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GradesMonth_MonthAcademic");
        });

        modelBuilder.Entity<GradesSemesterTb>(entity =>
        {
            entity.HasKey(e => e.GradesSemesterId).HasName("PK__GradesSe__47B98A5E328DF4E3");

            entity.ToTable("GradesSemesterTB");

            entity.Property(e => e.GradesText).HasMaxLength(255);
            entity.Property(e => e.GradesValue).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Note).HasMaxLength(255);

            entity.HasOne(d => d.DistrSubTeacher).WithMany(p => p.GradesSemesterTbs)
                .HasForeignKey(d => d.DistrSubTeacherId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GradesSemester_DistributionSubTeacher");

            entity.HasOne(d => d.FileStudent).WithMany(p => p.GradesSemesterTbs)
                .HasForeignKey(d => d.FileStudentId)
                .HasConstraintName("FK_GradesSemester_FileStudent");

            entity.HasOne(d => d.GradesType).WithMany(p => p.GradesSemesterTbs)
                .HasForeignKey(d => d.GradesTypeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_GradesSemester_Grades");

            entity.HasOne(d => d.SemesterAcademic).WithMany(p => p.GradesSemesterTbs)
                .HasForeignKey(d => d.SemesterAcademicId)
                .HasConstraintName("FK_GradesSemester_SemesterAcademic");
        });

        modelBuilder.Entity<GradesTb>(entity =>
        {
            entity.HasKey(e => e.GradesTypeId).HasName("PK__Grades__189B958B89B60DB9");

            entity.ToTable("GradesTB");

            entity.Property(e => e.GradesName).HasMaxLength(255);
            entity.Property(e => e.GradesType).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
        });

        modelBuilder.Entity<HomeworkTb>(entity =>
        {
            entity.HasKey(e => e.HomeworkId).HasName("PK__Homework__FDE46A72ABC66B98");

            entity.ToTable("HomeworkTB");

            entity.Property(e => e.HomeworkText).HasMaxLength(255);
            entity.Property(e => e.HomeworkTitle).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.SubmissionDate).HasColumnType("date");

            entity.HasOne(d => d.DistrSubTeacher).WithMany(p => p.HomeworkTbs)
                .HasForeignKey(d => d.DistrSubTeacherId)
                .HasConstraintName("FK_Homework_DistributionSubTeacher");

            entity.HasOne(d => d.MonthAcademic).WithMany(p => p.HomeworkTbs)
                .HasForeignKey(d => d.MonthAcademicId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Homework_MonthAcademic");
        });

        modelBuilder.Entity<InstallmentTb>(entity =>
        {
            entity.HasKey(e => e.InstallmentId);

            entity.ToTable("InstallmentTB");

            entity.Property(e => e.InstallmentDateEnd).HasColumnType("date");
            entity.Property(e => e.InstallmentDateSt).HasColumnType("date");
            entity.Property(e => e.InstallmentDueDate).HasColumnType("date");
            entity.Property(e => e.InstallmentName).HasMaxLength(50);
            entity.Property(e => e.InstallmentRate).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.TuitionFeeInstallment).WithMany(p => p.InstallmentTbs)
                .HasForeignKey(d => d.TuitionFeeInstallmentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_InstallmentTB_TuitionFeeInstallmentTB");
        });

        modelBuilder.Entity<JopTypeTb>(entity =>
        {
            entity.HasKey(e => e.JopTypeId);

            entity.ToTable("JopTypeTB");

            entity.Property(e => e.JopTyp).HasMaxLength(50);
            entity.Property(e => e.JopTypeName).HasMaxLength(50);
            entity.Property(e => e.Note)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<MonthAcademicTb>(entity =>
        {
            entity.HasKey(e => e.MonthAcademicId).HasName("PK__MonthAca__373B69C88051408B");

            entity.ToTable("MonthAcademicTB");

            entity.Property(e => e.Note).HasMaxLength(255);

            entity.HasOne(d => d.Month).WithMany(p => p.MonthAcademicTbs)
                .HasForeignKey(d => d.MonthId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_MonthAcademic_Month");

            entity.HasOne(d => d.SemesterAcademic).WithMany(p => p.MonthAcademicTbs)
                .HasForeignKey(d => d.SemesterAcademicId)
                .HasConstraintName("FK_MonthAcademic_SemesterAcademic");
        });

        modelBuilder.Entity<MonthTb>(entity =>
        {
            entity.HasKey(e => e.MonthId).HasName("PK__Month__9FA83FA608693520");

            entity.ToTable("MonthTB");

            entity.Property(e => e.MonthName).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
        });

        modelBuilder.Entity<ParentTb>(entity =>
        {
            entity.HasKey(e => e.ParentId).HasName("PK__Parent__D339516F15450AC5");

            entity.ToTable("ParentTB");

            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.JopTitle).HasMaxLength(100);
            entity.Property(e => e.NationalId).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.NationalType)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.ParentName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ReleaseDate).HasColumnType("date");

            entity.HasOne(d => d.User).WithMany(p => p.ParentTbs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Parent_UserData");
        });

        modelBuilder.Entity<ParticiStudentActivTb>(entity =>
        {
            entity.HasKey(e => e.ParticiStudentActivId).HasName("ParticiStudentActiFk");

            entity.ToTable("ParticiStudentActivTB");

            entity.Property(e => e.DocmunetStatus).HasMaxLength(150);

            entity.HasOne(d => d.FileStudent).WithMany(p => p.ParticiStudentActivTbs)
                .HasForeignKey(d => d.FileStudentId)
                .HasConstraintName("FK_ParticiStudentActivTB_FileStudentTB");

            entity.HasOne(d => d.StudentActivitie).WithMany(p => p.ParticiStudentActivTbs)
                .HasForeignKey(d => d.StudentActivitieId)
                .HasConstraintName("FK_ParticiStudentActivTB_StudentActivitieTB");
        });

        modelBuilder.Entity<PreparationTb>(entity =>
        {
            entity.HasKey(e => e.PreparationId).HasName("PK__Preparat__092D2B4BF320586C");

            entity.ToTable("PreparationTB");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.PreparationDate).HasColumnType("date");

            entity.HasOne(d => d.DistrSubTeacher).WithMany(p => p.PreparationTbs)
                .HasForeignKey(d => d.DistrSubTeacherId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Preparation_DistributionSubTeacher");

            entity.HasOne(d => d.FileStudent).WithMany(p => p.PreparationTbs)
                .HasForeignKey(d => d.FileStudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Preparation_FileStudent");

            entity.HasOne(d => d.MonthAcademic).WithMany(p => p.PreparationTbs)
                .HasForeignKey(d => d.MonthAcademicId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Preparation_MonthAcademic");
        });

        modelBuilder.Entity<QualificationTb>(entity =>
        {
            entity.HasKey(e => e.QualificationId).HasName("PK__Qualific__C95C12AA4FAC0E16");

            entity.ToTable("QualificationTB");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.QualificationName).HasMaxLength(100);
        });

        modelBuilder.Entity<SchoolGroupTb>(entity =>
        {
            entity.HasKey(e => e.SchoolGroupId).HasName("PK__SchoolGr__ADAE98C01CC0AC21");

            entity.ToTable("SchoolGroupTB");

            entity.Property(e => e.SchoolGroupName).HasMaxLength(255);
        });

        modelBuilder.Entity<SchoolTb>(entity =>
        {
            entity.HasKey(e => e.SchoolId).HasName("PK__School__3DA4675B39E0B356");

            entity.ToTable("SchoolTB");

            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SchoolAddress).HasMaxLength(255);
            entity.Property(e => e.SchoolName).HasMaxLength(255);
            entity.Property(e => e.SchoolPrincipal).HasMaxLength(255);

            entity.HasOne(d => d.SchoolGroup).WithMany(p => p.SchoolTbs)
                .HasForeignKey(d => d.SchoolGroupId)
                .HasConstraintName("FK_School_SchoolGroup");
        });

        modelBuilder.Entity<SectionCodeTb>(entity =>
        {
            entity.HasKey(e => e.SectionCodeId).HasName("PK__SectionCode");

            entity.ToTable("SectionCodeTB");

            entity.Property(e => e.SectionCodeCode).HasMaxLength(50);
            entity.Property(e => e.SectionCodeName).HasMaxLength(255);
        });

        modelBuilder.Entity<SectionDataTb>(entity =>
        {
            entity.HasKey(e => e.SectionId).HasName("PK__SectionD__80EF0872BAF2A6B6");

            entity.ToTable("SectionDataTB");

            entity.Property(e => e.SectionCode).HasMaxLength(50);
            entity.Property(e => e.SectionName).HasMaxLength(255);

            entity.HasOne(d => d.Class).WithMany(p => p.SectionDataTbs)
                .HasForeignKey(d => d.ClassId)
                .HasConstraintName("FK_SectionData_ClassData");

            entity.HasOne(d => d.SectionCodeNavigation).WithMany(p => p.SectionDataTbs)
                .HasForeignKey(d => d.SectionCodeId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SectionDataTB_SectionCodeTB");
        });

        modelBuilder.Entity<SemesterAcademicTb>(entity =>
        {
            entity.HasKey(e => e.SemesterAcademicId).HasName("PK__Semester__C81E51ABD798E18C");

            entity.ToTable("SemesterAcademicTB");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.SemesterAcademicTitel).HasMaxLength(150);
            entity.Property(e => e.SemesterAcademicType).HasMaxLength(50);
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.Semester).WithMany(p => p.SemesterAcademicTbs)
                .HasForeignKey(d => d.SemesterId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SemesterAcademic_SemesterAcademic");

            entity.HasOne(d => d.Year).WithMany(p => p.SemesterAcademicTbs)
                .HasForeignKey(d => d.YearId)
                .HasConstraintName("FK_SemesterAcademic_YearData");
        });

        modelBuilder.Entity<SemesterTb>(entity =>
        {
            entity.HasKey(e => e.SemesterId).HasName("PK__Semester__043301DD9A97A177");

            entity.ToTable("SemesterTB");

            entity.Property(e => e.SemesterName).HasMaxLength(255);
            entity.Property(e => e.SemesterType).HasMaxLength(50);
        });

        modelBuilder.Entity<SpecializationTb>(entity =>
        {
            entity.HasKey(e => e.SpecializationId).HasName("PK__Speciali__5809D86F148F32CB");

            entity.ToTable("SpecializationTB");

            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.SpecializationName).HasMaxLength(100);
        });

        modelBuilder.Entity<StageTb>(entity =>
        {
            entity.HasKey(e => e.StageId).HasName("PK__Stage__03EB7AD867D82C54");

            entity.ToTable("StageTB");

            entity.Property(e => e.StageName).HasMaxLength(255);
        });

        modelBuilder.Entity<StreetsTb>(entity =>
        {
            entity.HasKey(e => e.StreetId);

            entity.ToTable("StreetsTB");

            entity.Property(e => e.Notes)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.StreetName).HasMaxLength(150);
        });

        modelBuilder.Entity<StudentActivitieTb>(entity =>
        {
            entity.HasKey(e => e.StudentActivitieId);

            entity.ToTable("StudentActivitieTB");

            entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Location).HasMaxLength(150);
            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.StudentActivitieDateEnd).HasColumnType("date");
            entity.Property(e => e.StudentActivitieDateSt).HasColumnType("date");
            entity.Property(e => e.StudentActivitieName).HasMaxLength(150);

            entity.HasOne(d => d.Teacher).WithMany(p => p.StudentActivitieTbs)
                .HasForeignKey(d => d.TeacherId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentActivitieTB_TeacherTB");

            entity.HasOne(d => d.TypeOfActivitie).WithMany(p => p.StudentActivitieTbs)
                .HasForeignKey(d => d.TypeOfActivitieId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_StudentActivitieTB_TypeOfActivitiesTB");
        });

        modelBuilder.Entity<StudentParticipationBusTb>(entity =>
        {
            entity.HasKey(e => e.StudentParticipationBusId);

            entity.ToTable("StudentParticipationBusTB");

            entity.Property(e => e.StudentParticipationBusId).ValueGeneratedNever();
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.ParticipationType).HasMaxLength(50);
            entity.Property(e => e.TimeAttendance).HasColumnType("datetime");
            entity.Property(e => e.TimeLeave).HasColumnType("datetime");
        });

        modelBuilder.Entity<StudentTb>(entity =>
        {
            entity.HasKey(e => e.StudentId).HasName("PK__Student__32C52B99D45F4808");

            entity.ToTable("StudentTB");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BirthDate).HasColumnType("date");
            entity.Property(e => e.BirthPlace)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.BusLine)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Country)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.District)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.EnrollmentDate).HasColumnType("date");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FourthName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullNameArabic)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullNameEnglish)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Gender)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.MobileNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nationality)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Note)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Province)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Religion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResidenceDistrict)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResidenceProvince)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ResidenceStreet)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.SecondName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.StudentPhoto)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.ThirdName)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.StudentTbs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_Student_UserData");
        });

        modelBuilder.Entity<StudentsParentRelTb>(entity =>
        {
            entity.HasKey(e => new { e.ParentId, e.StudentId }).HasName("PK__Students__501503D678C1DA47");

            entity.ToTable("StudentsParentRelTB");

            entity.Property(e => e.Relationship)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.Parent).WithMany(p => p.StudentsParentRelTbs)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK_ParentRel");

            entity.HasOne(d => d.Student).WithMany(p => p.StudentsParentRelTbs)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK_StudentsParentRel");
        });

        modelBuilder.Entity<SubjectTb>(entity =>
        {
            entity.HasKey(e => e.SubjectId).HasName("PK__Subject__AC1BA3A81E2B8C02");

            entity.ToTable("SubjectTB");

            entity.Property(e => e.HighScore).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.LowScore).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.SubjectNameArabic).HasMaxLength(255);
            entity.Property(e => e.SubjectNameEnglish).HasMaxLength(255);
            entity.Property(e => e.SubjectType).HasMaxLength(50);
        });

        modelBuilder.Entity<SubmittedHomeworkTb>(entity =>
        {
            entity.HasKey(e => e.SubmittedHomeworkId).HasName("PK__Submitte__6C275D0ED8E2CF33");

            entity.ToTable("SubmittedHomeworkTB");

            entity.Property(e => e.HomeworkText).HasMaxLength(255);
            entity.Property(e => e.HomeworkTitle).HasMaxLength(255);
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.SubmittedDate).HasColumnType("date");

            entity.HasOne(d => d.FileStudent).WithMany(p => p.SubmittedHomeworkTbs)
                .HasForeignKey(d => d.FileStudentId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubmittedHomework_FileStudent");

            entity.HasOne(d => d.Homework).WithMany(p => p.SubmittedHomeworkTbs)
                .HasForeignKey(d => d.HomeworkId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_SubmittedHomework_Homework");
        });

        modelBuilder.Entity<TeacherTb>(entity =>
        {
            entity.HasKey(e => e.TeacherId).HasName("PK__Teacher__EDF259645192328F");

            entity.ToTable("TeacherTB");

            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(25);
            entity.Property(e => e.TeacherName).HasMaxLength(255);

            entity.HasOne(d => d.Qualification).WithMany(p => p.TeacherTbs)
                .HasForeignKey(d => d.QualificationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Teacher_Qualification");

            entity.HasOne(d => d.Specialization).WithMany(p => p.TeacherTbs)
                .HasForeignKey(d => d.SpecializationId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Teacher_Specialization");

            entity.HasOne(d => d.User).WithMany(p => p.TeacherTbs)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_Teacher_UserData");
        });

        modelBuilder.Entity<TrafficLineTb>(entity =>
        {
            entity.HasKey(e => e.TrafficLineId);

            entity.ToTable("TrafficLineTB");

            entity.Property(e => e.Description).HasMaxLength(150);
            entity.Property(e => e.TrafficLineName).HasMaxLength(50);
        });

        modelBuilder.Entity<TuitionFeeInstallmentTb>(entity =>
        {
            entity.HasKey(e => e.TuitionFeeInstallmentId);

            entity.ToTable("TuitionFeeInstallmentTB");

            entity.Property(e => e.DateFristInstallment).HasColumnType("date");
            entity.Property(e => e.TuitionFeeInstallmentName).HasMaxLength(100);
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.ClassTuitionFees).WithMany(p => p.TuitionFeeInstallmentTbs)
                .HasForeignKey(d => d.ClassTuitionFeesId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_TuitionFeeInstallmentTB_ClassTuitionFeesTB");

            entity.HasOne(d => d.Year).WithMany(p => p.TuitionFeeInstallmentTbs)
                .HasForeignKey(d => d.YearId)
                .HasConstraintName("FK_TuitionFeeInstallmentTB_YearDataTB");
        });

        modelBuilder.Entity<TypeOfActivitiesTb>(entity =>
        {
            entity.HasKey(e => e.TypeOfActivitieId);

            entity.ToTable("TypeOfActivitiesTB");

            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.TypeOfActivitieName).HasMaxLength(150);
        });

        modelBuilder.Entity<TypesDiscountsTb>(entity =>
        {
            entity.HasKey(e => e.TypesDiscountId).HasName("PK_TypesOpponentTB");

            entity.ToTable("TypesDiscountsTB");

            entity.Property(e => e.Note).HasColumnType("text");
            entity.Property(e => e.TypesDiscountName).HasMaxLength(50);
        });

        modelBuilder.Entity<TypesTuitionFeesTb>(entity =>
        {
            entity.HasKey(e => e.TypesTuitionFeesId);

            entity.ToTable("TypesTuitionFeesTB");

            entity.Property(e => e.Notes).HasColumnType("text");
            entity.Property(e => e.TypesTuitionFeesName).HasMaxLength(150);
        });

        modelBuilder.Entity<UserDataTb>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserData__1788CC4CEA6F8B48");

            entity.ToTable("UserDataTB");

            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VacationsTb>(entity =>
        {
            entity.HasKey(e => e.VacationId).HasName("PK_Vacations");

            entity.ToTable("VacationsTB");

            entity.Property(e => e.VacationDateEnd).HasColumnType("date");
            entity.Property(e => e.VacationDateSt).HasColumnType("date");
            entity.Property(e => e.VacationName).HasMaxLength(150);
            entity.Property(e => e.VacationType).HasMaxLength(50);
            entity.Property(e => e.YearId).HasMaxLength(55);

            entity.HasOne(d => d.Year).WithMany(p => p.VacationsTbs)
                .HasForeignKey(d => d.YearId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_VacationsTB_YearDataTB");
        });

        modelBuilder.Entity<YearDataTb>(entity =>
        {
            entity.HasKey(e => e.YearId).HasName("PK__YearData__C33A18CD750DBE34");

            entity.ToTable("YearDataTB");

            entity.Property(e => e.YearId).HasMaxLength(55);
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.YearName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
