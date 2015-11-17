using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces;
using System;

namespace IndicacaoCerta.Infra.Data.Repositorio
{
    public class UsuarioComunRepositorioBase : RepositorioBase<UsuarioComun>, IUsuarioComunRepositorioBase
    {
        public void Add(UsuarioComun usuarioDomain)
        {
            throw new NotImplementedException();
        }
    }
}
