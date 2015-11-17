using IndicacaoCerta.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace IndicacaoCerta.Infra.Data.EntityConfig
{
    public class AvaliacaoConfiguration : EntityTypeConfiguration<Avaliacao>
    {
        public AvaliacaoConfiguration()
        {
            HasKey(a => a.AvaliacaoId);

            Property(a => a.DescricaoAvaliacao)
                .IsRequired()
                .HasMaxLength(150);


                HasRequired(a => a.Chamado)
                .WithMany()
                .HasForeignKey(a => a.ChamadosId);
        }

    }
}
