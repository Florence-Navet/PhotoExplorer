using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PhotoExplorer.Components.Services;
using PhotoExplorer.Explorer;
using PhotoExplorer.Explorer.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri
    (builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPhotoService, WASMPhotoService>();

await builder.Build().RunAsync();
