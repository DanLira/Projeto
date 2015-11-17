using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IRepositorios;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces
{
    public interface ICategoriaRepositorioBase : IRepositorioBase<Categoria>
    {
        IEnumerable<Categoria> BuscaPorEspecialidade(string Especialidade);

        IEnumerable<Categoria> BuscaPorTipoCategoria(string TipoCategoria);
    }
}
