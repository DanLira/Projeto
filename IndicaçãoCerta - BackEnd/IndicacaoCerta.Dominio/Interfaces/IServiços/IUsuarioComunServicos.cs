using IndicacaoCerta.Dominio.Entidades;
using System.Collections;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces.IServiços
{
    public interface IUsuarioComunServicos : IServicosBase<UsuarioComun>
    {
        IEnumerable<UsuarioComun> ObterAutonomo(IEnumerable<UsuarioComun> usuarioComun);
    }
}
