using FluentValidation;
using FluentValidation.AspNetCore;
using System.Reflection;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Context;
using TemizKodunOnemi.AdvancedOrnek.WebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());



builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://127.0.0.1:5500");
    });
});

//builder.Services.AddTransient<ExceptionMiddleware>();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

builder.Services.AddScoped<ApplicationDbContext>();
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

//app.UseMiddleware<ExceptionMiddleware>();

app.UseExceptionHandler();

app.UseAuthorization();

app.MapControllers();

app.Run();
