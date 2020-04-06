using CertificateProject.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace CertificateProject.Infrastructure
{
    public class CertificateContext : DbContext
    {
        public CertificateContext(DbContextOptions<CertificateContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CertificateEntity>()
                .HasIndex(q => q.SequenceNumber)
                .IsUnique();

            CertificateInitializer.Seed(modelBuilder);
        }

        public DbSet<CertificateEntity> CertificateEntities { get; set; }
    }

}
