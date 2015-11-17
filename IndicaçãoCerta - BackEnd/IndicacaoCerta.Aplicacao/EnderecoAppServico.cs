using System;
using System.Collections.Generic;
using IndicacaoCerta.Aplicacao.Interface;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;

namespace IndicacaoCerta.Aplicacao
{
    public class EnderecoAppServico : AppServicosBase<Endereco>, IEnderecoAppServico
    {

        private readonly IEnderecoServicos _enderecoServico;

        public EnderecoAppServico(IEnderecoServicos enderecoServico)
            : base(enderecoServico)
        {
            _enderecoServico = enderecoServico;
        }


        public IEnumerable<Endereco> BuscaPorCidade(string cidade)
        {
            return _enderecoServico.BuscaPorCidade(_enderecoServico.GetAll(cidade));
        }
    }
}
