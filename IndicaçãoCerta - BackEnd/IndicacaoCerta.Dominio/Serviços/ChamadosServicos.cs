using System;
using System.Collections.Generic;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using IndicacaoCerta.Dominio.Interfaces;

namespace IndicacaoCerta.Dominio.Serviços
{
    public class ChamadosServicos : ServicosBase<Chamados>, IChamadosServicos
    {
        private readonly IChamadosRepositorioBase _chamadosRepositorio;

        public ChamadosServicos(IChamadosRepositorioBase chamadosRepositorio)
            :base(chamadosRepositorio)
        {
            _chamadosRepositorio = chamadosRepositorio;
        }

        public IEnumerable<Chamados> BuscaPorNumeroChamados(int numeroChamado)
        {
            return _chamadosRepositorio.BuscaPorNumeroChamados(numeroChamado);
        }
    }
}
