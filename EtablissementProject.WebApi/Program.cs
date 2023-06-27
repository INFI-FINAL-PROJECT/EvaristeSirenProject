using EtablissementProject.BusinessLogic.data;
using EtablissementProject.BusinessLogic.Interfaces;
using EtablissementProject.BusinessLogic.Services;
using EtablissementProject.DataAccess.Interfaces;
using EtablissementProject.DataAccess.Repositories;
using MongoDB.Driver;
using MongoDB.Driver.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpClient();
builder.Services.AddScoped<IEtablissementService, EtablissementService>();
builder.Services.AddScoped<IEntrepriseRepository, EntrepriseRepository>();
builder.Services.AddScoped<IEtablissementService, EtablissementService>();

builder.Services.Configure<DataBaseSetting>(builder.Configuration.GetSection("Database"));
var dbSettings = builder.Configuration.GetSection("Database").Get<DataBaseSetting>();

builder.Services.AddSingleton<IMongoClient>(_ =>
{
    MongoClientSettings mongoSettings = MongoClientSettings.FromConnectionString(dbSettings.ConnectionString);
    mongoSettings.LinqProvider = LinqProvider.V3;

    return new MongoClient(mongoSettings);
});

builder.Services.AddScoped<IMongoDatabase>(x =>
{
    var client = x.GetRequiredService<IMongoClient>();
    return client.GetDatabase(dbSettings.DatabaseName);
});


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
