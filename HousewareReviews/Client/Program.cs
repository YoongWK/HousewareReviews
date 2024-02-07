using HousewareReviews.Client;
using HousewareReviews.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Toolbelt.Blazor.Extensions.DependencyInjection;

// Create a new WebAssemblyHostBuilder
var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Configure the root components for the application
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// Add an HttpClient named "private" for private server communication.
builder.Services.AddHttpClient("private", (sp, client) => {
	client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
	client.EnableIntercept(sp);
	})
	.AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();

// Add an HttpClient named "public" for public server communication
builder.Services.AddHttpClient("public", (sp, client) => {
	client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress);
	client.EnableIntercept(sp);
	});

// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("HousewareReviews.ServerAPI"));

// Add HttpClientInterceptor & HttpInterceptorService for handling HTTP request interception.
builder.Services.AddHttpClientInterceptor();
builder.Services.AddScoped<HttpInterceptorService>();

// Add ApiAuthorization & specify a custom claims principal factory for role-based authorization
builder.Services.AddApiAuthorization()
    .AddAccountClaimsPrincipalFactory<CustomUserFactory>();

// Build & run the Blazor WebAssembly application
await builder.Build().RunAsync();
