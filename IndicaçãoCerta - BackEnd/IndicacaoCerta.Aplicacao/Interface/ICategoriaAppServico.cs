using IndicacaoCerta.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicacaoCerta.Aplicacao.Interface
{
    public interface ICategoriaAppServico : IAppServicoBase<Categoria>
    {
        

        IEnumerable<Categoria> BuscaPorEspecialidade(string Especialidade);

        IEnumerable<Categoria> BuscaPorTipoCategoria(string TipoCategoria);
    }
}
