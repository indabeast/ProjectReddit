using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using ProRedClient;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Set the BaseAddress to the API endpoint
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5157") });

await builder.Build().RunAsync();