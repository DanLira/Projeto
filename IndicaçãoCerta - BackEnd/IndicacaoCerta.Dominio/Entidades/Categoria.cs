namespace IndicacaoCerta.Dominio.Entidades
{
    public class Categoria
    {
        public int CategoriaId {get; set;}

        public string TipoCategoria { get; set; }

        public string Especialidade { get; set; }

        public int UsuarioComunId { get; set; }

        public virtual UsuarioComun usuarioComun { get; set; }
    }
}
