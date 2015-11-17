using IndicacaoCerta.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace IndicacaoCerta.Infra.Data.EntityConfig
{
    public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfiguration()
        {
            HasKey(e => e.EnderecoId);

            Property(e => e.Cep)
                .IsRequired()
                .HasMaxLength(8);

            HasRequired(e => e.usuarioComun)
                .WithMany()
                .HasForeignKey(e => e.UsuarioComunId);
        }

    }
}
