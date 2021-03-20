using System.ComponentModel.DataAnnotations;

namespace Curso.Api.Models.Usuarios
{
    public class RegistroViewModelInput
    {
        [Display(Name = "Login")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Login { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Senha { get; set; }
    }
}
