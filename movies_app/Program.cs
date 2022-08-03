using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using movies_app.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.vvvvvvvvvvvvv
builder.Services.AddRazorPages();
builder.Services.AddDbContext<movies_appContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("movies_appContext") ?? throw new InvalidOperationException("Connection string 'movies_appContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();