using IndicacaoCerta.Aplicacao.Interface;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;

namespace IndicacaoCerta.Aplicacao
{
    public class UsuarioSystemAppServico : AppServicosBase<UsuarioSystem>, IUsuarioSystemAppServico
    {
        private readonly IUsuarioSystemServicos _usuarioSystemServico;

        public UsuarioSystemAppServico(IUsuarioSystemServicos usuarioSystemServico)
            :base(usuarioSystemServico)
            {
            _usuarioSystemServico = usuarioSystemServico;
            }
    }
}
