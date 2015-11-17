using System;
using System.ComponentModel.DataAnnotations;

namespace IndicacaoCerta.MVC.ViewModels
{
    public class ChamadosViewModel
    {
        [Key]
        public int ChamadosId { get; set; }

        public string StatosChamado { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int UsuarioComunId { get; set; }

        public virtual UsuarioComunViewModel usuarioComun { get; set; }
    }
}