using BooksApp.Contracts;
using BooksApp.Middlewares;
using BooksApp.Services;
using BooksAppData;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddTransient<IBookService, DbBookService>();
builder.Services.AddTransient<IAuthorService, DbAuthorService>();
builder.Services.AddTransient<IPublisherService, DbPublisherService>();
builder.Services.AddTransient<IAnalyticsService, DbAnalyticsService>();
builder.Services.AddTransient<IPageService, DbPageService>();
builder.Services.AddSingleton<IDateTimeProvider, CurrentDateTimeProvider>();
builder.Services.AddDbContext<AppDbContext>();
builder.Services.AddDefaultIdentity<IdentityUser>().AddRoles<IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddSingleton<LastVisitMiddleware>();
builder.Services.AddTransient<AnalyticsMiddleware>();
builder.Services.AddTransient<PageListMiddleware>();

builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

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
app.UseMiddleware<LastVisitMiddleware>();
app.UseMiddleware<AnalyticsMiddleware>();
app.UseMiddleware<PageListMiddleware>();
app.UseAuthentication();
app.UseAuthorization();
app.UseSession();
app.MapRazorPages();

app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller}/{action}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();