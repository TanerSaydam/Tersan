using NTierArchitecture.Business.Services;
using NTierArchitecture.DataAccess;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddDataAccess(builder.Configuration);

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

app.UseAuthorization();

app.MapControllers();

app.Run();
