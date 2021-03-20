using System.ComponentModel.DataAnnotations;

namespace Curso.Api.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Display(Name ="Login")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Login { get; set; }

        [Display(Name ="Senha")]
        [Required(ErrorMessage = "O campo {0} é obrigatório!")]
        public string Senha { get; set; }
    }
}
