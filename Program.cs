using BlazorAppSyncfusion;
using Syncfusion.Blazor;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NTk4MDIwQDMxMzkyZTM0MmUzMGx6cml2cXlEK1BXUGhSeG5DU3lESm1leFJuenJ1ZVFGWGtzeXcwSXBrUms9");
var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddSyncfusionBlazor(options => { options.IgnoreScriptIsolation = true; });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
