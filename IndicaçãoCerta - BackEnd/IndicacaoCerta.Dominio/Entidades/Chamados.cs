

using System;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Entidades
{
    public class Chamados
    {
        public int ChamadosId { get; set; }

        public string StatosChamado { get; set; }

        public DateTime DataInicio { get; set; }

        public DateTime DataTermino { get; set; }

        public int UsuarioComunId { get; set; }

        public virtual UsuarioComun usuarioComun { get; set; }

        public virtual IEnumerable<Avaliacao> avaliacao { get; set; }

       
    }
}
