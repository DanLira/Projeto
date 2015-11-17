using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IRepositorios;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Interfaces
{
    public interface IEnderecoRepositorioBase : IRepositorioBase<Endereco>
    {
        IEnumerable<Endereco> BuscaPorCidade(string cidade);
    }
}
