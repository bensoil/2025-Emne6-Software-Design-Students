using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StudentBloggClient;
using StudentBloggClient.Services.Api;
using StudentBloggClient.Services.Auth;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped<IBasicAuthStore, BasicAuthStore>();
builder.Services.AddHttpClient<IUsersApiClient, UsersApiClient>().ConfigureHttpClient((sp, client) =>
{
    client.BaseAddress = new Uri("https://localhost:7213;http://localhost:7213");
});

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
