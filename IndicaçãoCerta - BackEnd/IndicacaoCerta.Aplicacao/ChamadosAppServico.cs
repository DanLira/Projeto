using IndicacaoCerta.Aplicacao.Interface;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using System.Collections.Generic;

namespace IndicacaoCerta.Aplicacao
{
    public class ChamadosAppServico : AppServicosBase<Chamados>, IChamadosAppServico
    {
        private readonly IChamadosServicos _chamadosServico;

        public ChamadosAppServico(IChamadosServicos chamadosServico )
            : base(chamadosServico)
        {
            _chamadosServico = chamadosServico;
        }

        public IEnumerable<Chamados> BuscaPorNumeroChamados(int numeroChamado)
        {
            return _chamadosServico.BuscaPorNumeroChamados(_chamadosServico.GetAll(numeroChamado));
        }
    }
}
