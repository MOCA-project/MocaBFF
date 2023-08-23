using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Moca.BFF.Api.Configurations.IoC;
using Moca.BFF.Api.Configurations.Swagger;
using System.Globalization;
using System.Text;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

//Controllers
builder.Services.AddControllers();
//Dependency Injections
builder.Services.AddDependencyInjections();
//Swagger   
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "MOCA - BFF", Version = "v1" });

    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                          new OpenApiSecurityScheme
                          {
                              Reference = new OpenApiReference
                              {
                                  Type = ReferenceType.SecurityScheme,
                                  Id = "Bearer"
                              }
                          },
                         new string[] {}
                    }
                });
});
//Options
builder.Services.AddOptions(config);
//Authentication
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    var key = Moca.BFF.Api.Configurations.Extensions.ConfigurationExtensions.GetIssuerSigningKey(config);
    var keyIssuer = Moca.BFF.Api.Configurations.Extensions.ConfigurationExtensions.GetSigningKeyIssuer(config);
    x.TokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key)),
        ValidateIssuer = false,
        ValidateIssuerSigningKey = true,
        ValidateAudience = false,
    };
});

//Authorization
builder.Services.AddAuthorization();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseRouting();
app.MapControllers();
app.UseAuthorization();


app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Moca - Moca.BFF.API"));

var cultureInfo = new CultureInfo("en-US");
cultureInfo.NumberFormat.CurrencySymbol = "R$";
CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;

app.Run();