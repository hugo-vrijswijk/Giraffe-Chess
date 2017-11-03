using GiraffeChess.ApplicationService.Entities;
using GiraffeChess.ApplicationService.Mapper;
using GiraffeChess.ApplicationService.Repository;
using GiraffeChess.DomainService;
using GiraffeChess.DomainService.Service;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GiraffeChess.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var dbConn = Configuration.GetConnectionString("DbConn");
            services.AddDbContext<ChessContext>(options => options.UseSqlServer(dbConn),
                ServiceLifetime.Scoped, ServiceLifetime.Singleton);
            services.AddTransient<BoardMapper>();
            services.AddTransient<IBoardRepository, BoardRepository>();
            services.AddTransient<IGameService, GameService>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
