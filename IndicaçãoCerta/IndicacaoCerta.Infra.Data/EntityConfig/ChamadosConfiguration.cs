using IndicacaoCerta.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace IndicacaoCerta.Infra.Data.EntityConfig
{
    public class ChamadosConfiguration : EntityTypeConfiguration<Chamados>
    {
        public ChamadosConfiguration()
        {
            HasKey(c => c.ChamadosId);

            HasRequired(c => c.usuarioComun)
                .WithMany()
                .HasForeignKey(c => c.UsuarioComunId);
        }

    }
}
