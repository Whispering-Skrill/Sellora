using Sellora.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Sellora.Client;
using Toolbelt.Blazor.Extensions.DependencyInjection;

// Creating a WebAssemblyHostBuilder instance
var builder = WebAssemblyHostBuilder.CreateDefault(args);


// Adding required services
builder.Services.AddOptions();
builder.Services.AddAuthorizationCore();

// Adding the root components for the application
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Configuring and adding HTTP client services
builder.Services.AddHttpClient("Sellora.ServerAPI", (sp, client) => { client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress); client.EnableIntercept(sp); })
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Supply HttpClient instances that include access tokens when making requests to the server project (For AuthStates)
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("Sellora.ServerAPI"));

// Adding HttpClientInterceptor for intercepting HTTP requests and responses (Global Error Handling)
builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<HttpInterceptorService>();

// Configuring API authorization and adding a custom user factory
builder.Services.AddApiAuthorization()
    .AddAccountClaimsPrincipalFactory<CustomUserFactory>();

// Building and running the Blazor WebAssembly application
await builder.Build().RunAsync();
