using IndicacaoCerta.Dominio.Entidades;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces.IServiços
{
    public interface IEnderecoServicos : IServicosBase<Endereco>
    {
        IEnumerable<Endereco> BuscaPorCidade(string cidade);
        string GetAll(string cidade);
    }
}
