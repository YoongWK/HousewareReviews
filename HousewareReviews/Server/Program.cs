using HousewareReviews.Server.Data;
using HousewareReviews.Server.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using HousewareReviews.Server.IRepository;
using HousewareReviews.Server.Repository;

// Creating a new web application
var builder = WebApplication.CreateBuilder(args);

// Get the connection string & throw an exception if not found
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");

// Add services to the container
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Configure identity services
builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

// Configure IdentityServer services
builder.Services.AddIdentityServer()
    .AddApiAuthorization<ApplicationUser, ApplicationDbContext>(options => {
        // Configure IdentityServer to include name and role claims in the ID token & access token
        options.IdentityResources["openid"].UserClaims.Add("name");
        options.ApiResources.Single().UserClaims.Add("name");
        options.IdentityResources["openid"].UserClaims.Add("role");
        options.ApiResources.Single().UserClaims.Add("role");
    });

// Configure authentication using IdentityServer JWT
builder.Services.AddAuthentication()
    .AddIdentityServerJwt();

// Add transient service for the Unit of Work pattern
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();

// Add controllers & Razor Pages services
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

// Build the web application
var app = builder.Build();

// Configure the HTTP request pipeline based on the environment.
if (app.Environment.IsDevelopment())
{
    // Enable endpoint for EF Core migrations & WebAssembly debugging in development
    app.UseMigrationsEndPoint();
    app.UseWebAssemblyDebugging();
}
else
{
    // Configure exception handling & HSTS in production
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Redirect HTTP to HTTPS
app.UseHttpsRedirection();

// Configure the use of Blazor framework files & static files
app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

// Configure routing, IdentityServer, & authorization
app.UseRouting();
app.UseIdentityServer();
app.UseAuthorization();

// Map Razor Pages, controllers, & fallback to serving "index.html" for unmatched routes
app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

// Run the application
app.Run();
