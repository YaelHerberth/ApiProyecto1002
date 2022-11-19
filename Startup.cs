using ApiProyecto1002.Context;
using Microsoft.EntityFrameworkCore;


namespace ApiProyecto1002
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            this.Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddControllers();
            service.AddDbContext<AppDbContext>(options => 
            options.UseSqlServer(Configuration.GetConnectionString("Conexion")));
        }
    }

    public void Configure(IApplicationBuilder app, IHostApplicationLifetime lifetime)
    {

    }
}
