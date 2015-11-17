using System.ComponentModel.DataAnnotations;

namespace IndicacaoCerta.MVC.ViewModels
{
    public class CategoriaViewModel
    {
        [Key]
        public int CategoriaId { get; set; }

        public string TipoCategoria { get; set; }

        public string Especialidade { get; set; }

        public int UsuarioComunId { get; set; }

        public virtual UsuarioComunViewModel usuarioComun { get; set; }
    }
}