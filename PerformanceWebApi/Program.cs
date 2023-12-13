using PerformanceWebApi.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTransient<PerformanceMiddleware>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<PerformanceMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();
