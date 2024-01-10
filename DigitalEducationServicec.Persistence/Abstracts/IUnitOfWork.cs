using DigitalEducationServicec.Persistence.Abstracts;


namespace DigitalEducationServicec.Persistence.Repositoriesr.Abstraction
{
    public interface IUnitOfWork : IDisposable
    {
        IAAcademicStatusRepository AcademicStatusesRepository { get; }
        IAcademicSystemsRepository AcademicSystemsRepository { get; }
        IClassDataRepository ClassDataRepository { get; }
        IMonthRepository MonthRepository { get; }
        IMonthAcademicRepository MonthAcademicRepository { get; }
        IParentRepository ParentRepository { get; }
        ISchoolRepository SchoolRepository { get; }
        ISchoolGroupRepository SchoolGroupRepository { get; }
        ISectionDataRepository SectionDataRepository { get; }
        ISemesterRepository SemesterRepository { get; }
        IStageRepository StageRepository { get; }
        IStudentRepository StudentRepository { get; }
        IStudentsParentRelRepository StudentsParentRelRepository { get; }
        ISubjectRepository SubjectRepository { get; }
        ITeacherRepository TeacherRepository { get; }
        ISpecializationRepository SpecializationRepository { get; }
        IQualificationRepository QualificationRepository { get; }
        IUserDataRepository UserRepository { get; }
        IYearDataRepository YearDataRepository { get; }
        IDistributionClassSubRepository DistributionClassSubRepository { get; }
        IDistributionSubTeacherRepository DistributionSubTeacherRepository { get; }
        IHomeworkRepository HomeworkRepository { get; }
        ISubmittedHomeworkRepository SubmittedHomeworkRepository { get; }
        IPreparationRepository PreparationRepository { get; }
        IGradesRepository GradesRepository { get; }
        IGradesSemesterRepository GradesSemesterRepository { get; }
        IGradesMonthRepository GradesMonthRepository { get; }
        IFileStudentRepository FileStudentRepository { get; }
        ISemesterAcademicRepository SemesterAcademicRepository { get; }
        IAcademicDiscountRepository AcademicDiscountRepository { get; }
        IAppreciationRepository AppreciationRepository { get; }
        IBusRepository BusRepository { get; }
        IClassTuitionFeesRepository ClassTuitionFeesRepository { get; }
        IDayDataRepository DayDataRepository { get; }
        IDistributionOfBuseStreetRepository DistributionOfBuseStreetRepository { get; }
        IDocmunetsClassRepository DocmunetsClassRepository { get; }
        IDocmunetsRepository DocmunetsRepository { get; }
        IDocmunetStudentRepository DocmunetStudentRepository { get; }
        IFinesRepository FinesRepository { get; }
        IInstallmentRepository InstallmentRepository { get; }
        IJopTypeRepository JopTypeRepository { get; }
        IParticiStudentActivRepository PartiStudentActivRepository { get; }
        ISectionCodeRepository SectionCodeRepository { get; }
        IStreetsRepository StreetsRepository { get; }
        IStudentActivitieRepository StudentActivitieRepository { get; }
        IStudentParticipationBusRepository StudentParticipationBusRepository { get; }
        ITrafficLineRepository TrafficLineRepository { get; }
        ITuitionFeeInstallmentRepository TuitionFeeInstallmentRepository { get; }
        ITypeOfActivitiesRepository TypeOfActivitiesRepository { get; }
        ITypesDiscountsRepository TypesDiscountsRepository { get; }
        ITypesTuitionFeesRepository TypesTuitionFeesRepository { get; }
        IVacationsRepository VacationsRepository { get; }
        void SaveChanges();

        Task<int> SaveChangesAsync();
    }
}
