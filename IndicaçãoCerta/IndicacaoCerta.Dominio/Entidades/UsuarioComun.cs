

using System;
using System.Collections.Generic;

namespace IndicacaoCerta.Dominio.Entidades
{
    public class UsuarioComun
    {
        public int UsuarioComunId { get; set; }

        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Email { get; set; }

        public string Site { get; set; }

        public int Telefone { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Profissional { get; set; }

        public virtual IEnumerable<Chamados> Chamado { get; set; }

        public virtual IEnumerable<Endereco> endereco { get; set; }

        public virtual IEnumerable<Categoria> categoria { get; set; }



        public bool UsuarioAutonomo(UsuarioComun usuario)
        {
            return usuario.Profissional;
        }

      

        

        
    }
}
