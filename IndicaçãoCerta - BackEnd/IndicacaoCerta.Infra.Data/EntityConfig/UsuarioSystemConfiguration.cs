using IndicacaoCerta.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace IndicacaoCerta.Infra.Data.EntityConfig
{
    public class UsuarioSystemConfiguration : EntityTypeConfiguration<UsuarioSystem>
    {
        public UsuarioSystemConfiguration()
        {
            HasKey(us => us.UsuarioSystemId);

            Property(us => us.Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(us => us.Senha)
                .IsRequired();
        }

    }
}
