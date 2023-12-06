using DependencyInjectionWebApi.Services;
using DependencyInjectionWebApi.Utilities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IProductService, ProductServiceWithMongoDb>();
builder.Services.AddScoped<ApplicationDbContext>();
builder.Services.Create();


builder.Services.AddScoped<OneService>();
builder.Services.AddScoped<TwoService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
