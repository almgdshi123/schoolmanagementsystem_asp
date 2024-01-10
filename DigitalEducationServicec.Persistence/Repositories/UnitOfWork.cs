using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Abstracts;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;

namespace DigitalEducationServicec.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DigitalEducationServiceDbnContext _context;

        public UnitOfWork(DigitalEducationServiceDbnContext context)
        {
            _context = context;
            AcademicStatusesRepository = new AcademicStatusesRepository(_context);
            AcademicSystemsRepository = new AcademicSystemsRepository(_context);
            ClassDataRepository = new ClassDataRepository(_context);
            MonthRepository = new MonthRepository(_context);
            MonthAcademicRepository = new MonthAcademicRepository(_context);
            ParentRepository = new ParentRepository(_context);
            SchoolRepository = new SchoolRepository(_context);
            SchoolGroupRepository = new SchoolGroupRepository(_context);
            SectionDataRepository = new SectionDataRepository(_context);
            SemesterRepository = new SemesterRepository(_context);
            StageRepository = new StageRepository(_context);
            StudentRepository = new StudentRepository(_context);
            StudentsParentRelRepository = new StudentsParentRelRepository(_context);
            SubjectRepository = new SubjectRepository(_context);
            TeacherRepository = new TeacherRepository(_context);
            SpecializationRepository = new SpecializationRepository(_context);
            QualificationRepository = new QualificationRepository(_context);
            UserRepository = new UserRepository(_context);
            YearDataRepository = new YearDataRepository(_context);
            DistributionClassSubRepository = new DistributionClassSubRepository(_context);
            DistributionSubTeacherRepository = new DistributionSubTeacherRepository(_context);
            HomeworkRepository = new HomeworkRepository(_context);
            SubmittedHomeworkRepository = new SubmittedHomeworkRepository(_context);
            PreparationRepository = new PreparationRepository(_context);
            GradesRepository = new GradesRepository(_context);
            GradesSemesterRepository = new GradesSemesterRepository(_context);
            GradesMonthRepository = new GradesMonthRepository(_context);
            FileStudentRepository = new FileStudentRepository(_context);
            SemesterAcademicRepository = new SemesterAcademicRepository(_context);

            AcademicDiscountRepository = new AcademicDiscountRepository(_context);
            AppreciationRepository = new AppreciationRepository(_context);
            BusRepository = new BusRepository(_context);
            ClassTuitionFeesRepository = new ClassTuitionFeesRepository(_context);
            DayDataRepository = new DayDataRepository(_context);
            DistributionOfBuseStreetRepository = new DistributionOfBuseStreetRepository(_context);
            DocmunetsClassRepository = new DocmumentsClassRepository(_context);
            DocmunetsRepository = new DocmunetsRepository(_context);
            DocmunetStudentRepository = new DocmunetStudentRepository(_context);
            FinesRepository = new FinesRepository(_context);
            InstallmentRepository = new InstallmentRepository(_context);
            JopTypeRepository = new JopTypeRepository(_context);
            PartiStudentActivRepository = new PartiStudentActivRepository(_context);
            SectionCodeRepository = new SectionCodeRepository(_context);
            StreetsRepository = new StreetsRepository(_context);
            StudentActivitieRepository = new StudentActivitieRepository(_context);
            StudentParticipationBusRepository = new StudentParticipationBusRepository(_context);
            TrafficLineRepository = new TrafficLineRepository(_context);
            TuitionFeeInstallmentRepository = new TuitionFeeInstallmentRepository(_context);
            TypeOfActivitiesRepository = new TypeOfActivitiesRepository(_context);
            TypesDiscountsRepository = new TypesDiscountsRepository(_context);
            TypesTuitionFeesRepository = new TypesTuitionFeesRepository(_context);
            VacationsRepository = new VacationsRepository(_context);
        }

        public IAAcademicStatusRepository AcademicStatusesRepository { get; }
        public IAcademicSystemsRepository AcademicSystemsRepository { get; }
        public IClassDataRepository ClassDataRepository { get; }
        public IMonthRepository MonthRepository { get; }
        public IMonthAcademicRepository MonthAcademicRepository { get; }
        public IParentRepository ParentRepository { get; }
        public ISchoolRepository SchoolRepository { get; }
        public ISchoolGroupRepository SchoolGroupRepository { get; }
        public ISectionDataRepository SectionDataRepository { get; }
        public ISemesterRepository SemesterRepository { get; }
        public IStageRepository StageRepository { get; }
        public IStudentRepository StudentRepository { get; }
        public IStudentsParentRelRepository StudentsParentRelRepository { get; }
        public ISubjectRepository SubjectRepository { get; }
        public ITeacherRepository TeacherRepository { get; }
        public ISpecializationRepository SpecializationRepository { get; }
        public IQualificationRepository QualificationRepository { get; }
        public IUserDataRepository UserRepository { get; }
        public IYearDataRepository YearDataRepository { get; }
        public IDistributionClassSubRepository DistributionClassSubRepository { get; }
        public IDistributionSubTeacherRepository DistributionSubTeacherRepository { get; }
        public IHomeworkRepository HomeworkRepository { get; }
        public ISubmittedHomeworkRepository SubmittedHomeworkRepository { get; }
        public IPreparationRepository PreparationRepository { get; }
        public IGradesRepository GradesRepository { get; }
        public IGradesSemesterRepository GradesSemesterRepository { get; }
        public IGradesMonthRepository GradesMonthRepository { get; }
        public IFileStudentRepository FileStudentRepository { get; }
        public ISemesterAcademicRepository SemesterAcademicRepository { get; }
        public IAcademicDiscountRepository AcademicDiscountRepository { get; }
        public IAppreciationRepository AppreciationRepository { get; }
        public IBusRepository BusRepository { get; }
        public IClassTuitionFeesRepository ClassTuitionFeesRepository { get; }
        public IDayDataRepository DayDataRepository { get; }
        public IDistributionOfBuseStreetRepository DistributionOfBuseStreetRepository { get; }
        public IDocmunetsClassRepository DocmunetsClassRepository { get; }
        public IDocmunetsRepository DocmunetsRepository { get; }
        public IDocmunetStudentRepository DocmunetStudentRepository { get; }
        public IFinesRepository FinesRepository { get; }
        public IInstallmentRepository InstallmentRepository { get; }
        public IJopTypeRepository JopTypeRepository { get; }
        public IParticiStudentActivRepository PartiStudentActivRepository { get; }
        public ISectionCodeRepository SectionCodeRepository { get; }
        public IStreetsRepository StreetsRepository { get; }
        public IStudentActivitieRepository StudentActivitieRepository { get; }
        public IStudentParticipationBusRepository StudentParticipationBusRepository { get; }
        public ITrafficLineRepository TrafficLineRepository { get; }
        public ITuitionFeeInstallmentRepository TuitionFeeInstallmentRepository { get; }
        public ITypeOfActivitiesRepository TypeOfActivitiesRepository { get; }
        public ITypesDiscountsRepository TypesDiscountsRepository { get; }
        public ITypesTuitionFeesRepository TypesTuitionFeesRepository { get; }
        public IVacationsRepository VacationsRepository { get; }
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // الإفراج عن الموارد التي تم استخدامها هنا
                    _context.Dispose();
                }

                disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //public void Dispose()
        //{
        //    throw new NotImplementedException();
        //}

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
