using Mis.Api.Extensions;
using MIS.Api.Extensions;
using MIS.Business.Extensions;
using MIS.Data.Extensions;
using Serilog;

var builder = WebApplication.CreateBuilder(args).ConfigureSerilog();

builder.Host.ConfigureAppConfiguration((hostingContext, config) =>
{
    config.Sources.Clear();

    config.SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile($"appsettings.{Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT")}.json", optional: false, reloadOnChange: true);
});

builder.Logging.AddConfiguration(builder.Configuration);
builder.Logging.AddSerilog();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

// Add Authentification here
builder.Services.AddMisData(builder.Configuration);
builder.Services.AddMisBusinessServices(builder.Configuration);
builder.Services.AddAutoMapper();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
