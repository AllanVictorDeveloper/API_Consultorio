using CL.Data.Context;
using CL.WebApi.Configuration;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

// Configura��o de FluentValidation
builder.Services.AddFluentValidatorConfiguration();

// Configura��o de AutoMapper
builder.Services.AddAutoMapperConfiguration();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddDbContext<CLContext>(options =>
                    options.UseSqlServer(builder.Configuration.GetConnectionString("Connection")));

// Configura��o de DependencyInjector
builder.Services.AddDependencyInjectorConfiguration();

// Configura��o do Swagger
builder.Services.AddSwaggerConfiguration();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

// Configura��o do Swagger
app.AppSwaggerConfiguration();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();