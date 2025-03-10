var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


var app = builder.Build();
app.UseRouting();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");


app.Run();