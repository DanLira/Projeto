using IndicacaoCerta.Dominio.Entidades;
using System.Collections.Generic;

namespace IndicacaoCerta.Aplicacao.Interface
{
    public interface IChamadosAppServico : IAppServicoBase<Chamados>
    {
        IEnumerable<Chamados> BuscaPorNumeroChamados(int numeroChamado);
    }
}
