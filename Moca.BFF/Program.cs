using Microsoft.AspNetCore.Builder;
using Moca.BFF.Configuration.IoC;
using Moca.BFF.Configuration.Swagger;
using System.Globalization;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;
//Controllers
builder.Services.AddControllers();
//Dependency Injections
builder.Services.AddDependencyInjections();
//Swagger   
builder.Services.AddSwagger();
//Options
builder.Services.AddOptions(config);

var app = builder.Build();

//LoggerAction as Middleware
app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.UseEndpoints(endpoints => {
    endpoints.MapControllers();
});

app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Moca - Moca.BFF.API"));

var cultureInfo = new CultureInfo("en-US");
cultureInfo.NumberFormat.CurrencySymbol = "R$";
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
app.Run();
