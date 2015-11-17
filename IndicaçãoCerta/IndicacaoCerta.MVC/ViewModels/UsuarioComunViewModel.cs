using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace IndicacaoCerta.MVC.ViewModels
{
    public class UsuarioComunViewModel
    {
        [Key]
        public int UsuarioComunId { get; set; }

        [Required(ErrorMessage ="Preencha o campo Nome")]
        [MaxLength(150, ErrorMessage ="Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage ="Minimo {0} caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha o campo Senha")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Minimo {0} caracteres")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [MaxLength(100, ErrorMessage = "Máximo {0} caracteres")]
        [EmailAddress(ErrorMessage ="Preencha um E-mail valido")]
        [DisplayName("E-mail")]
        public string Email { get; set; }

        public string Site { get; set; }

        public int Telefone { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        public bool Profissional { get; set; }

        public virtual IEnumerable<ChamadosViewModel> Chamado { get; set; }

        public virtual IEnumerable<EnderecoViewModel> endereco { get; set; }

        public virtual IEnumerable<CategoriaViewModel> categoria { get; set; }
    }
}