using CleanArchitecture.Application;
using CleanArchitecture.Infrastructure;
using Microsoft.AspNetCore.OData;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication().AddJwtBearer(
    cfr => cfr.TokenValidationParameters = new()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidateLifetime = true,
        ValidIssuer = "Taner Saydam",
        ValidAudience = "Herkes",
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key my secret key "))
 });

builder.Services.AddAuthorization();

builder.Services.AddApplication();
builder.Services.AddInfrastructure();

builder.Services.AddControllers().AddOData(opt=>
{
    opt.EnableQueryFeatures();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
