using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Thisney.Ticket.Application.Costumer;
using Thisney.Ticket.Application.Event;
using Thisney.Ticket.Application.Ticket;
using Thisney.Ticket.Database.Context;
using Thisney.Ticket.DataBase.Infra;
using Thisney.Ticket.DataBase.Infra.Costumer;
using Thisney.Ticket.DataBase.Infra.Event;
using Thisney.Ticket.DataBase.Infra.Ticket;
using Thisney.Ticket.Domain;

namespace Api
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddScoped<IRepository<CostumerEntity>, CostumerRepository>();
            services.AddScoped<ICostumerApplicationService, CostumerApplicationService>();

            services.AddScoped<IRepository<TicketEntity>, TicketRepository>();
            services.AddScoped<ITicketApplicationService, TicketApplicationService>();

            services.AddScoped<IRepository<EventEntity>, EventRepository>();
            services.AddScoped<IEventApplicationService, EventApplicationService>();

            var connection = Configuration.GetConnectionString(nameof(Context));
            services.AddDbContext<Context>((options) => options.UseSqlServer(connection));

            services.AddScoped<IUnityOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                //builder.WithOrigins("http://localhost:1234");
                builder.AllowAnyOrigin();
            });

            app.UseMvcWithDefaultRoute();
        }
    }
}
