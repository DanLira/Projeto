using System.ComponentModel.DataAnnotations;

namespace IndicacaoCerta.MVC.ViewModels
{
    public class UsuarioSystemViewModel
    {
        [Key]
        public int UsuarioSystemId { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Senha { get; set; }
    }
}