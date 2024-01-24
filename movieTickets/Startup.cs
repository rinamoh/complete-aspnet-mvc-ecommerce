/*using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using movieTickets.Data;

namespace movieTickets
{
    public class Startup

    {
        public Startup(IConfiguration configuration)
        {

            Configuration = configuration;

        }
        public IConfiguration Configuration { get;  }
        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        }
        public void ConfigureServices(IServiceCollection services)
        {
            //db context configuration
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnectionString")));
            services.AddControllersWithViews();
            
           
        }
    }
}
*/