using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using CleanArchitecture.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(configure =>
{
    configure.AddDefaultPolicy(policy => policy.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin());
});

builder.Services.AddInfrastructure(builder.Configuration);
builder.Services.AddApplication();

builder.Services.AddTransient<ExceptionMiddleware>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseMiddlewareExtensions();

app.UseAuthorization();

app.MapControllers();

app.Run();
