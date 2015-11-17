using IndicacaoCerta.Dominio.Entidades;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces.IServiços
{
    public interface IChamadosServicos : IServicosBase<Chamados>
    {
        IEnumerable<Chamados> BuscaPorNumeroChamados(int numeroChamado);
        int GetAll(int numeroChamado);
    }
}
