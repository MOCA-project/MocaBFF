using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Crosscuting.Models
{
    public class ApiRegisterUserResponse
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Email { get; set; }

        public int IdTipoPerfil { get; set; }

        public string Telefone { get; set; }

        public bool EnviaEmail { get; set; }

        public bool EnviaSms { get; set; }
    }
}
