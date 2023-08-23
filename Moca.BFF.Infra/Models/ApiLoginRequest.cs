using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Crosscuting.Models
{
    public class ApiLoginRequest
    {
        public string Senha { get; set; }
        public string Email { get; set; }

        public ApiLoginRequest(string senha, string email)
        {
            this.Email = email;
            this.Senha = senha;
        }
    }
}
