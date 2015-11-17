using System;
using System.Collections.Generic;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using IndicacaoCerta.Dominio.Interfaces;

namespace IndicacaoCerta.Dominio.Serviços
{
    public class EnderecoServicos : ServicosBase<Endereco>, IEnderecoServicos
    {
        private readonly IEnderecoRepositorioBase _enderecoRepositorio;

        public EnderecoServicos(IEnderecoRepositorioBase enderecoRepositorio)
            :base(enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }
        public IEnumerable<Endereco> BuscaPorCidade(string cidade)
        {
            return _enderecoRepositorio.BuscaPorCidade(cidade);
        }
    }
}
