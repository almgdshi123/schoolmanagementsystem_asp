using DigitalEducationServicec.Domain.Entity;
using DigitalEducationServicec.Persistence.Repositories;
using DigitalEducationServicec.Persistence.Repositoriesr.Abstraction;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DigitalEducationServicec.Persistence
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DigitalEducationServiceDbnContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            //services.AddTransient<IAAcademicStatusRepository, AcademicStatusesRepository>();
            //services.AddTransient<IAcademicSystemsRepository, AcademicSystemsRepository>();
            //services.AddTransient<IClassDataRepository, ClassDataRepository>();
            //services.AddTransient<IParentRepository, ParentRepository>();
            //services.AddTransient<ISemesterRepository, SemesterRepository>();
            //services.AddTransient<IStageRepository, StageRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();


            services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));
            return services;
        }
    }
}