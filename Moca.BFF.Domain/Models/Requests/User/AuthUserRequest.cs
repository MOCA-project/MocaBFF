namespace Moca.BFF.Domain.Models.Requests.User
{
    public class AuthUserRequest
    {
        public required string Email { get; set; }
        public required string Senha { get; set; }
    }
}
