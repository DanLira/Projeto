using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace IndicacaoCerta.Infra.Data.Repositorio
{
    public class CategoriaRepositorioBase : RepositorioBase<Categoria>, ICategoriaRepositorioBase
    {
        public IEnumerable<Categoria> BuscaPorEspecialidade(string Especialidade)
        {
            return Db.categoria.Where(ct=> ct.Especialidade == Especialidade);
        }

        public IEnumerable<Categoria> BuscaPorTipoCategoria(string TipoCategoria)
        {
            return Db.categoria.Where(ct => ct.TipoCategoria == TipoCategoria);
        }
    }
}
