using dvonna.Site.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace dvonna.Site
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();

            services.AddLocalization();

            AddDataClient(services);

            services.AddScoped<IUserPreferences, UserPreferences>();
            services.AddScoped<IMessageService, MessageService>();
        }

        private void AddDataClient(IServiceCollection services)
        {
            services.Configure<DvOnnaConfig>(Configuration.GetSection(nameof(DvOnnaConfig)));

            services.AddHttpClient("data", (sp, c) =>
            {
                c.BaseAddress = sp.GetRequiredService<IOptions<DvOnnaConfig>>().Value.DataEndpoint;
            })
            .AddTypedClient(c => Refit.RestService.For<IScoreService>(c))
            .AddTypedClient(c => Refit.RestService.For<IPlayerService>(c))
            .AddTypedClient(c => Refit.RestService.For<IAgendaService>(c))
            .AddTypedClient(c => Refit.RestService.For<IPlayedGamesService>(c))
            .AddTypedClient(c => Refit.RestService.For<IMessageServiceClient>(c));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            var config = app.ApplicationServices.GetRequiredService<IOptions<DvOnnaConfig>>().Value;
            app.UseRequestLocalization(config.Culture);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
