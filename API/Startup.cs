using Microsoft.OpenApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Mvc.Controllers;


namespace API
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            AdicionarControladores(services);
            AdicionarDataContext(services, Configuration.GetConnectionString("BibliotecaVivaApiConnection"));
            RealizarInjecaoDeDependenciasBLL(services);
            RealizarInjecaoDeDependenciasDAL(services);
            DefinirConfiguracaoSwagger(services);           
        }

        private static void AdicionarControladores(IServiceCollection services)
        {
            services.AddControllers().AddNewtonsoftJson();
        }
        private static void AdicionarDataContext(IServiceCollection services, string connectionString)
        {
            //services.AddDbContext<bibliotecavivaContext>(options => options.UseNpgsql(connectionString));
        }

        private static void RealizarInjecaoDeDependenciasBLL(IServiceCollection services)
        {
            //services.AddScoped<ITipoBLL, TipoBLL>();
        }

        private static void RealizarInjecaoDeDependenciasDAL(IServiceCollection services)
        { 
            //services.AddScoped<ITipoDAL, TipoDAL>();
        }

        private static void DefinirConfiguracaoSwagger(IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Biblioteca Viva API", Version = "v1" });
                options.CustomOperationIds(d => (d.ActionDescriptor as ControllerActionDescriptor)?.ActionName);
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            var swaggerOptions = new SwaggerOptions();
            Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

            app.UseSwagger(option => { 
                option.RouteTemplate = swaggerOptions.JsonRoute;
            });

            app.UseSwaggerUI(option => {
                option.RoutePrefix = swaggerOptions.RoutePrefix;
                option.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description);
            });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        } 
    }
}