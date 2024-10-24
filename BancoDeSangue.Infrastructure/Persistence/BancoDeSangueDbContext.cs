using BancoDeSangue.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace BancoDeSangue.Infrastructure.Persistence
{
    public class BancoDeSangueDbContext : DbContext
    {
        public BancoDeSangueDbContext(DbContextOptions<BancoDeSangueDbContext> options)
            :base(options)
        {
            
        }

        public DbSet<Doador> Doadores { get; set; }
        public DbSet<Doacao> Doacoes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<EstoqueSangue> EstoqueSangues { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<Doador>(x =>
                {
                    x.HasKey(x => x.Id);

                    x.HasOne(x => x.Endereco)
                        .WithOne()
                        .HasForeignKey<Endereco>(x => x.IdEndereco)
                        .OnDelete(DeleteBehavior.Restrict);

                    x.HasMany(x => x.Doacoes)
                        .WithOne(x => x.Doador)
                        .HasForeignKey(x => x.IdDoador)
                        .OnDelete(DeleteBehavior.Restrict);
                });

            builder
                .Entity<Doacao>(x =>
                {
                    x.HasKey(x => x.Id);

                    x.HasOne(x => x.Doador)
                        .WithMany(x => x.Doacoes)
                        .HasForeignKey(x => x.Id)
                        .OnDelete(DeleteBehavior.Restrict);

                });

            builder
                .Entity<Endereco>(x =>
                {
                    x.HasKey(x => x.Id);

                });

            builder
                .Entity<EstoqueSangue>(x =>
                {
                    x.HasKey(x => x.Id);
                });

            base.OnModelCreating(builder);
        }
    }
}
