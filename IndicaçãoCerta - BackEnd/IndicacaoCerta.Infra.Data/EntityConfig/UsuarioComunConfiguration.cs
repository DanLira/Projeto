using IndicacaoCerta.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace IndicacaoCerta.Infra.Data.EntityConfig
{
    public class UsuarioComunConfiguration : EntityTypeConfiguration<UsuarioComun>
    {
        public UsuarioComunConfiguration()
        {
            HasKey(u => u.UsuarioComunId);

            Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(u => u.Senha)
                .IsRequired();

            Property(u => u.Email)
                .IsRequired();

        }
    
    }
}
