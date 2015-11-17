using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace IndicacaoCerta.Infra.Data.Repositorio
{
    public class EnderecoRepositorioBase : RepositorioBase<Endereco>, IEnderecoRepositorioBase
    {
        public IEnumerable<Endereco> BuscaPorCidade(string cidade)
        {
            return Db.endereco.Where(e => e.Cidade == cidade);
        }
    }
}
