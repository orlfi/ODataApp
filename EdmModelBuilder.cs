using Microsoft.OData.Edm;
using Microsoft.OData.ModelBuilder;
using ODataApp.Data.Models;

namespace ODataApp;

public static class EdmModelBuilder
{
    public static IEdmModel Build()
    {
        // create OData builder instance
        var builder = new ODataConventionModelBuilder();

        // map the entityset which is the type returned
        // from the endpoint onto the OData pipeline
        // the string parameter is the name of the controller 
        // which supplies the data of type HeroModel in this case

        var weatherForecast = builder
            .EntitySet<WeatherForecast>("WeatherForecast")
                .EntityType.HasKey(x => x.Id);

        weatherForecast
            .Count()
            .Filter()
            .OrderBy()
            .Expand()
            .Select()
            .Page(100, 100);

        // return the fully configured builder model 
        // on which the OData library shall be built

        return builder.GetEdmModel();
    }
}
