using Microsoft.EntityFrameworkCore;
using Momentum.Components;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MomentumDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MomentumConnection")));


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Register TodoService
builder.Services.AddScoped<TodoService>();  


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
