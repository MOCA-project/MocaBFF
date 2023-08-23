using Microsoft.OpenApi.Models;
using System.Reflection;

namespace Moca.BFF.Configuration.Swagger
{
    public static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "MOCA - BFF",
                    Version = "v1",
                    Description = "API Services",
                    Contact = new OpenApiContact
                    {
                        Name = "MOCA - Money Care",
                        Url = new Uri("https://github.com/MOCA-projecthttps://github.com/MOCA-project")
                    }
                });

                c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, "Moca.BFF.xml"));
            });
        }
    }
}
