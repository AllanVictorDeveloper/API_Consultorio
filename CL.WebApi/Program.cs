using CL.Data.Context;
using CL.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Configuração de FluentValidation
builder.Services.AddFluentValidatorConfiguration();

// Configuração de AutoMapper
builder.Services.AddAutoMapperConfiguration();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<CLContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

// Configuração de DependencyInjector
builder.Services.AddDependencyInjectorConfiguration();

// Configuração do Swagger
builder.Services.AddSwaggerConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Configuração do Swagger
app.AppSwaggerConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();