using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using IndicacaoCerta.Dominio.Interfaces;

namespace IndicacaoCerta.Dominio.Serviços
{
    public class CategoriaServicos : ServicosBase<Categoria>, ICategoriaServicos
    {

        private readonly ICategoriaRepositorioBase _categoriaRepositorio;

        public CategoriaServicos(ICategoriaRepositorioBase categoriaRepositoro)
            :base(categoriaRepositoro)
        {
            _categoriaRepositorio = categoriaRepositoro;
        }

    }
}
