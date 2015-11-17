namespace IndicacaoCerta.Dominio.Entidades
{
    public class Endereco
    {
        public int EnderecoId {get; set;}

        public string Cep { get; set; }

        public string Rua { get; set; }

        public int Numero { get; set; }

        public string Bairro { get; set; }

        public string Cidade { get; set; }

        public string Estado { get; set; }

        public int UsuarioComunId { get; set; }

        public virtual UsuarioComun usuarioComun { get; set; }

    }
}
