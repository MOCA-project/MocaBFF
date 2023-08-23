using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moca.BFF.Domain.Models.Requests.User
{
    public class RegisterUserRequest
    {
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Email é obrigatório.")]
        [EmailAddress(ErrorMessage = "O campo Email deve ser um endereço de email válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Senha é obrigatório.")]
        [MinLength(6, ErrorMessage = "A senha deve ter no mínimo 6 caracteres.")]
        public string Senha { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Selecione um tipo de perfil válido.")]
        public int IdTipoPerfil { get; set; }

        [Phone(ErrorMessage = "O campo Telefone deve ser um número de telefone válido.")]
        public string Telefone { get; set; }
    }
}
