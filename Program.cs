using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MeuPortfolio;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// HttpClient apontando para sua API no Render
// Troque pela URL real da sua API
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://med-lembretederemedios.onrender.com")
});

await builder.Build().RunAsync();
