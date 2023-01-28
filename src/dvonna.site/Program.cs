using System;
using System.Globalization;
using Blazored.LocalStorage;
using dvonna.Site;
using dvonna.Site.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddLocalization();

builder.Services.Configure<DvOnnaConfig>(builder.Configuration.GetSection(nameof(DvOnnaConfig)));

builder.Services.AddHttpClient("data", (sp, c) =>
                {
                    c.BaseAddress = sp.GetRequiredService<IOptions<DvOnnaConfig>>().Value.DataEndpoint;
                })
                .AddTypedClient(c => Refit.RestService.For<IScoreService>(c))
                .AddTypedClient(c => Refit.RestService.For<IPlayerService>(c))
                .AddTypedClient(c => Refit.RestService.For<IAgendaService>(c))
                .AddTypedClient(c => Refit.RestService.For<IPlayedGamesService>(c))
                .AddTypedClient(c => Refit.RestService.For<IMessageServiceClient>(c));

builder.Services.AddScoped<IUserPreferences, UserPreferences>();
builder.Services.AddScoped<IMessageService, MessageService>();
builder.Services.AddBlazoredLocalStorage();

var culture = builder.Configuration["DvOnnaConfig:Culture"];
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo(culture);
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo(culture);

await builder.Build().RunAsync();
