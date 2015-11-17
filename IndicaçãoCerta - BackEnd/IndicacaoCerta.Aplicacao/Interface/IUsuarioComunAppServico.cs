using IndicacaoCerta.Dominio.Entidades;
using System.Collections.Generic;

namespace IndicacaoCerta.Aplicacao.Interface
{
    public interface IUsuarioComunAppServico : IAppServicoBase<UsuarioComun>
    {
        IEnumerable<UsuarioComun> ObterAutonomo();
    }
}
