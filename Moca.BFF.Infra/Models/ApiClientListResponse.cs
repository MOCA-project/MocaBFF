namespace Moca.BFF.External.Models
{
    public class ApiClientListResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int IdPerfil { get; set; }
        public DateTime? UltimoAcesso { get; set; }
        public string Telefone { get; set; }
        public bool EnviaEmail { get; set; }
        public bool EnviaSms { get; set; }

    }
}
