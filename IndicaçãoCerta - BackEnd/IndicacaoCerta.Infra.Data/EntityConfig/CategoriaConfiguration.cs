using IndicacaoCerta.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace IndicacaoCerta.Infra.Data.EntityConfig
{
    public class CategoriaConfiguration : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfiguration()
        {
            HasKey(ct => ct.CategoriaId);

            HasRequired(ct => ct.usuarioComun)
                .WithMany()
                .HasForeignKey(ct => ct.UsuarioComunId);

        }

    }
}
