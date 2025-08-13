using CompanyManagement.Application.Services;
using CompanyManagement.Domain.Interfaces;
using CompanyManagement.Infrastructure.Data;
using CompanyManagement.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CompanyManagement.Infrastructure.DependencyInjection;

public static class ServiceRegistration
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
    {
        // Use InMemory for development/testing if no database is available
        services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("CompanyDb"));
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        services.AddScoped<CompanyService>();

        return services;
    }
}