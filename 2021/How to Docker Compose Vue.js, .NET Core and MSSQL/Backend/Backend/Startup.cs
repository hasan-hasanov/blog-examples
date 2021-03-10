using DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Backend
{
    public class Startup
    {
        private readonly IConfigurationRoot _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = new ConfigurationBuilder()
              .AddJsonFile("appsettings.Development.json", optional: true)
              .AddJsonFile("appSettings.json", optional: true)
              .AddEnvironmentVariables()
              .Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddDbContext<PhoneBookContext>(options =>
            {
                options.UseSqlServer(_configuration.GetConnectionString("PhoneBook"));
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Backend", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, PhoneBookContext context)
        {
            app.UseHttpsRedirection();
            context.Database.Migrate();

            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Backend v1"));
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
