using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using royaltjänstflytt.Common.Mapping;
using royaltjänstflytt.Context;
using royaltjänstflytt.Feature;
using royaltjänstflytt.Helper;

namespace royaltjänstflytt
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPresistance(this IServiceCollection service, ConfigurationManager configuration)
        {
            var databaseConnection = new DatabaseConnectionSettings();
            configuration.Bind(DatabaseConnectionSettings.SectionName, databaseConnection);
            service.AddSingleton(Options.Create(databaseConnection));

            service.AddDbContext<CleanContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
            service.AddMappings();
            // This For Update Database Every Run App Or Publish Not Need To Include Migration When Publish
            using (var serviceScope = service.BuildServiceProvider().CreateScope())
            {
                var dbContext = serviceScope.ServiceProvider.GetRequiredService<CleanContext>();
                dbContext.Database.Migrate();
            }
            service.AddScoped<IMainService, MainService>();
            return service;
        }
    }
}
