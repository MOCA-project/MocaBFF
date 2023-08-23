namespace Moca.BFF.Api.Configurations.Extensions
{
    public static class ConfigurationExtensions
    {
        public static string GetIssuerSigningKey(this IConfiguration configuration)
        {
            string result = configuration.GetValue<string>("JwtSettings:Key");
            return result;
        }

        public static string GetSigningKeyIssuer(this IConfiguration configuration)
        {
            string result = configuration.GetValue<string>("JwtSettings:Issuer");
            return result;
        }
    }
}
