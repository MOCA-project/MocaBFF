using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Models.Responses
{
    public class GetAllUsersResponse
    {
        public List<GetAllUsersResponseContent> response = new();
    }

    public class GetAllUsersResponseContent
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
