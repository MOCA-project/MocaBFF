namespace Moca.BFF.External.Models
{
    public class ApiLoginRequest
    {
        public string Senha { get; set; }
        public string Email { get; set; }

        public ApiLoginRequest(string senha, string email)
        {
            Email = email;
            Senha = senha;
        }
    }
}
