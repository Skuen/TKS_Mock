using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TKS_Mock.Data;
using TKS_Mock_Data_Access.Utility;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

// Connection
CConfig.TKS_Mock_Conn_String = builder.Configuration.GetConnectionString("TKS_Mock_Conn_String");

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
