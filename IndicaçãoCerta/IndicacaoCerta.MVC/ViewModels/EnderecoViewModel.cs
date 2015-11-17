using System.ComponentModel.DataAnnotations;

namespace IndicacaoCerta.MVC.ViewModels
{
    public class EnderecoViewModel
    {
        [Key]
        public int EnderecoId { get; set; }

        public string Cep { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public virtual UsuarioComunViewModel usuarioComun { get; set; }
    }
}