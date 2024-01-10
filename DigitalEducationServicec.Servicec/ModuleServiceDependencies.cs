using DigitalEducationServicec.Servicec.Abstraction;
using DigitalEducationServicec.Servicec.Implementation;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalEducationServicec.Servicec
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            services.AddTransient<IAcademicStatusService, AcademicStatusService>();
            services.AddTransient<IAcademicSystemService, AcademicSystemService>();
            services.AddTransient<IClassDataService, ClassDataService>();
            services.AddTransient<IParentService, ParentService>();
            services.AddTransient<ISemesterService, SemesterService>();
            services.AddTransient<IStageService, StageService>();
            services.AddTransient<IGradesService, GradesService>();

            services.AddTransient<IStudentService, StudentService>();


            services.AddTransient<IDistributionClassSubService, DistributionClassSubService>();
            services.AddTransient<IDistributionSubTeacherService, DistributionSubTeacherService>();
            services.AddTransient<IFileStudentService, FileStudentService>();
            services.AddTransient<IGradesMonthService, GradesMonthService>();
            services.AddTransient<IGradesSemesterService, GradesSemesterService>();
            services.AddTransient<IHomeworkService, HomeworkService>();
            services.AddTransient<IMonthAcademicService, MonthAcademicService>();

            services.AddTransient<IMonthService, MonthService>();
            services.AddTransient<IPreparationService, PreparationService>();
            services.AddTransient<IQualificationService, QualificationService>();
            services.AddTransient<ISchoolGroupService, SchoolGroupService>();
            services.AddTransient<ISchoolService, SchoolService>();

            services.AddTransient<ISectionDataService, SectionDataService>();
            services.AddTransient<ISemesterAcademicService, SemesterAcademicService>();
            services.AddTransient<ISpecializationService, SpecializationService>();
            services.AddTransient<IStudentService, StudentService>();
            services.AddTransient<IStudentsParentRelService, StudentsParentRelService>();

            services.AddTransient<ISubjectService, SubjectService>();
            services.AddTransient<ISubmittedHomeworkService, SubmittedHomeworkService>();
            services.AddTransient<ITeacherService, TeacherService>();

            services.AddTransient<IUserDataService, UserDataService>();

            services.AddTransient<IYearDataService, YearDataService>();


            services.AddTransient<IAcademicDiscountService, AcademicDiscountService>();
            services.AddTransient<IAppreciationService, AppreciationService>();
            services.AddTransient<IBusService, BusService>();
            services.AddTransient<IClassTuitionFeesService, ClassTuitionFeesService>();
            services.AddTransient<IDayDataService, DayDataService>();
            services.AddTransient<IDistributionOfBuseStreetService, DistributionOfBusesStreetService>();
            services.AddTransient<IDocmumentsClassService, DocmumentsClassService>();
            services.AddTransient<IDocmumentsService, DocmumentsService>();
            services.AddTransient<IDocmunetStudentService, DocumentStudentService>();
            services.AddTransient<IFinesService, FinesService>();
            services.AddTransient<IInstallmentService, InstallmentService>();
            services.AddTransient<IJopTypeService, JopTypeService>();
            services.AddTransient<IParticiStudentActivService, ParticipStudentActivService>();
            services.AddTransient<ISectionCodeService, SectionCodeService>();
            services.AddTransient<IStreetsService, StreetsService>();
            services.AddTransient<IStudentActivitieService, StudentActivityService>();
            services.AddTransient<IStudentParticipationBusService, StudentParticipationBusService>();
            services.AddTransient<ITrafficLineService, TrafficLineService>();
            services.AddTransient<ITuitionFeeInstallmentService, TuitionFeeInstallmentService>();
            services.AddTransient<ITypeOfActivitiesService, TypeOfActivitiesService>();
            services.AddTransient<ITypesDiscountsService, TypesDiscountsService>();
            services.AddTransient<ITypesTuitionFeesService, TypesTuitionFeesService>();
            services.AddTransient<IVacationsService, VacationsService>();


            //services.AddTransient<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}