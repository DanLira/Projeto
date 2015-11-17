using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IRepositorios;
using IndicacaoCerta.Dominio.Interfaces.IServiços;

namespace IndicacaoCerta.Dominio.Serviços
{
    public class UsuarioSystemServicos : ServicosBase<UsuarioSystem>, IUsuarioSystemServicos
    {
        private readonly IUsuarioSystemRepositorioBase _usuarioSystemRepositorio;

        public UsuarioSystemServicos(IUsuarioSystemRepositorioBase usuarioSystemRepositorio)
            : base(usuarioSystemRepositorio)
        {
            _usuarioSystemRepositorio = usuarioSystemRepositorio;
        }

    }
}
