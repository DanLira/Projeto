using IndicacaoCerta.Aplicacao.Interface;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicacaoCerta.Aplicacao
{
    public class CategoriaAppServico : AppServicosBase<Categoria>, ICategoriaAppServico
    {

        private readonly ICategoriaServicos _categoriaServico;

        public CategoriaAppServico(ICategoriaServicos categoriaServico)
            : base(categoriaServico)
        {
            _categoriaServico = categoriaServico;
        }

        public IEnumerable<Categoria> BuscaPorEspecialidade(string Especialidade)
        {
            return _categoriaServico.BuscaPorEspecialidade(_categoriaServico.GetAll(Especialidade));
        }

        public IEnumerable<Categoria> BuscaPorTipoCategoria(string TipoCategoria)
        {
            return _categoriaServico.BuscaPorTipoCategoria(_categoriaServico.GetAll(TipoCategoria));
        }
    }
}
