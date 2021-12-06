using Microsoft.AspNetCore.OData;
using Microsoft.OData.Edm;
using ODataApp.Data.Interfaces;
using ODataApp.Data.Repositories;
using ODataApp;

var builder = WebApplication.CreateBuilder(args);

IEdmModel model = EdmModelBuilder.Build();

builder.Services.AddControllers().AddOData(opt =>
    opt.AddRouteComponents("odata", model)
    );

builder.Services.AddSingleton<IWeatherForecastRepository, WeatherForecastRepository>();

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

