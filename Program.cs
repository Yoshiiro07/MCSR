using Microsoft.EntityFrameworkCore;
using Catalog.API.Infrastructure;
using Catalog.API.Services;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure DbContext to use SQLite
builder.Services.AddDbContext<CatalogContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("ItemCatalogConnection")));

//ConnectionString SQL Express
/*"ItemCatalogConnection": "Server=DESKTOP-JEAJGEF\\SQLEXPRESS;Database=catalogbase;Trusted_Connection=True;TrustServerCertificate=True"*/

builder.Services.AddScoped<ICatalogRepository, CatalogRepository>();

// Ignorar erros de certificado (apenas para desenvolvimento)
ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
