using System.Linq;
using System.Collections.Generic;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces;
using IndicacaoCerta.Dominio.Interfaces.IServiços;

namespace IndicacaoCerta.Dominio.Serviços
{
    public class UsuarioComunServicos : ServicosBase<UsuarioComun>, IUsuarioComunServicos
    {
        private readonly IUsuarioComunRepositorioBase _usuarioComunRepositorio;


        public UsuarioComunServicos(IUsuarioComunRepositorioBase usuarioComunRepositorio)
            :base(usuarioComunRepositorio)
        {
            _usuarioComunRepositorio = usuarioComunRepositorio;
        }

        public IEnumerable<UsuarioComun> ObterAutonomo(IEnumerable<UsuarioComun> usuarioComun)
        {
            return usuarioComun.Where(u => u.UsuarioAutonomo(u));
        }
    }
}
