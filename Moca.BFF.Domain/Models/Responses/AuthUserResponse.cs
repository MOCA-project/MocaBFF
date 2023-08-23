namespace Moca.BFF.Domain.Models.Responses
{
    public class AuthUserResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public int IdTipoPerfil { get; set; }
    }
}
