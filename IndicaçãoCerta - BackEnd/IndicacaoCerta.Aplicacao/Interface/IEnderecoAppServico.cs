using IndicacaoCerta.Dominio.Entidades;
using System.Collections.Generic;

namespace IndicacaoCerta.Aplicacao.Interface
{
    public interface IEnderecoAppServico : IAppServicoBase<Endereco>
    {
        IEnumerable<Endereco> BuscaPorCidade(string cidade);
    }
}
