using IndicacaoCerta.Dominio.Entidades;
using IndicacaoCerta.Infra.Data.EntityConfig;
using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;


namespace IndicacaoCerta.Infra.Data.Context
{
    public class ProjetoContext : DbContext
    {

        public ProjetoContext()
            :base("ProjetoIndicacaoCerta")
        {

        }

        public DbSet<UsuarioComun> UsuarioComun { get; set; }
        public DbSet<Chamados> Chamado { get; set; }
        public DbSet<Endereco> endereco { get; set; }
        public DbSet<UsuarioSystem> usuarioSystem { get; set; }
        public DbSet<Categoria> categoria { get; set; }
        public DbSet<Avaliacao> avaliacao { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new UsuarioComunConfiguration());
            modelBuilder.Configurations.Add(new ChamadosConfiguration());
            modelBuilder.Configurations.Add(new EnderecoConfiguration());
            modelBuilder.Configurations.Add(new UsuarioSystemConfiguration());
            modelBuilder.Configurations.Add(new CategoriaConfiguration());
            modelBuilder.Configurations.Add(new AvaliacaoConfiguration());


        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {

                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;
                }
                if (entry.State == EntityState.Modified)
                {
                    entry.Property("DataCadastro").IsModified = false;
                }
            }


            return base.SaveChanges();
        }

    }
}
