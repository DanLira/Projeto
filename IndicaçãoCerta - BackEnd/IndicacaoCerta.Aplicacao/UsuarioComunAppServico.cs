using IndicacaoCerta.Aplicacao.Interface;
using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Dominio.Interfaces.IServiços;
using System;
using System.Collections.Generic;

namespace IndicacaoCerta.Aplicacao
{
    public class UsuarioComunAppServico : AppServicosBase<UsuarioComun>, IUsuarioComunAppServico
    {
        private readonly IUsuarioComunServicos _usuarioComunServico;

        public UsuarioComunAppServico(IUsuarioComunServicos usuarioComunServico)
            :base(usuarioComunServico)
        {
            _usuarioComunServico = usuarioComunServico;
        }

        public IEnumerable<UsuarioComun> ObterAutonomo()
        {
            return _usuarioComunServico.ObterAutonomo(_usuarioComunServico.GetAll());
        }
    }
}
