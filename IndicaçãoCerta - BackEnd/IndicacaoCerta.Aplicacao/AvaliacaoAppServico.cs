using IndicacaoCerta.Aplicacao.Interface;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;

namespace IndicacaoCerta.Aplicacao
{
   public class AvaliacaoAppServico : AppServicosBase<Avaliacao>, IAvaliacaoAppServico
    {
        private readonly IAvaliacaoServicos _avaliacaoServico;

        public AvaliacaoAppServico(IAvaliacaoServicos avaliacaoServico)
            : base(avaliacaoServico)
        {
            _avaliacaoServico = avaliacaoServico;
        }
    }
}
