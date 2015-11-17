using IndicacaoCerta.Dominio.Entidades;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces.IServiços
{
    public interface ICategoriaServicos : IServicosBase<Categoria>
    {

        IEnumerable<Categoria> BuscaPorEspecialidade(string Especialidade);

        IEnumerable<Categoria> BuscaPorTipoCategoria(string TipoCategoria);
        string GetAll(string especialidade);
    }
}
