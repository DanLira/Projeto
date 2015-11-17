using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces;
using System;
using System.Collections.Generic;

namespace IndicacaoCerta.Infra.Data.Repositorio
{
    public class ChamadosRepositorioBase : RepositorioBase<Chamados>, IChamadosRepositorioBase
    {
        public IEnumerable<Chamados> BuscaPorNumeroChamados(int numeroChamado)
        {
            throw new NotImplementedException();
        }
    }
}
