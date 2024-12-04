using API_16246.Models; // Update namespace if necessary
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddDbContext<ReceptionDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Optional: Add Swagger for API documentation
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error"); // Adjust if you have a dedicated error-handling controller
}

// Middleware for serving static files (useful for SPA frontend integration)
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Enable Swagger
app.UseSwagger();
app.UseSwaggerUI();

app.MapControllers();

// Optional: Remove or modify this route if not using MVC
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
