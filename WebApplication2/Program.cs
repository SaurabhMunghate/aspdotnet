using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Repository.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Add DbContext
// Assuming builder is an instance of WebHostBuilderContext

string connectionString = builder.Configuration.GetConnectionString("MySqlConnection");

if (connectionString != null)
{
    builder.Services.AddDbContext<ApplicationDbContext>(options =>
        options.UseMySQL(connectionString));
}
else
{
    // Handle the case when the connection string is null, perhaps by logging an error or using a default connection string.
}


var builder = WebApplication.CreateBuilder(args);
// Cookie configuration for HTTP to support cookies with SameSite=None
builder.Services.ConfigureSameSiteNoneCookies();

// Cookie configuration for HTTPS
//  builder.Services.Configure<CookiePolicyOptions>(options =>
//  {
//     options.MinimumSameSitePolicy = SameSiteMode.None;
//  });
builder.Services.AddAuth0WebAppAuthentication(options =>
{
    options.Domain = builder.Configuration["Auth0:Domain"];
    options.ClientId = builder.Configuration["Auth0:ClientId"];
});
builder.Services.AddControllersWithViews();
var app = builder.Build();


var app = builder.Build();

//builder.Services.AddTransient<IEmailSender, EmailSender>();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
