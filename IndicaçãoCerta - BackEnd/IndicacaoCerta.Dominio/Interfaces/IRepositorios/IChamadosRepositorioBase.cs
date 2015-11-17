using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IRepositorios;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces
{
    public interface IChamadosRepositorioBase : IRepositorioBase<Chamados>
    {
        IEnumerable<Chamados> BuscaPorNumeroChamados(int numeroChamado);
    }
}
