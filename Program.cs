using Microsoft.EntityFrameworkCore;
using Mocanu_project;

var builder = WebApplication.CreateBuilder(args);
var allowedOrigins = "allowed_origins";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: allowedOrigins,
        policyBuilder => { policyBuilder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod().Build(); });
});
// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlite("Data Source=F:\\VisualStudio\\repos\\Mocanu_project\\SQLite\\database.db"));

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(allowedOrigins);
app.UseHttpsRedirection();
app.Use(async (context, next) =>
{
    context.Response.Headers.Add("Access-Control-Allow-Origin", "*");
    context.Response.Headers.Add("Access-Control-Allow-Methods", "POST, GET, OPTIONS, PUT, HEAD, DELETE, PATCH");
    await next();
});
app.UseAuthorization();

app.MapControllers();

app.Run();
