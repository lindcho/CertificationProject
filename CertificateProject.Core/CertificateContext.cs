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

            CertificateInitializer.Seed(modelBuilder);
        }

        public DbSet<CertificateEntity> CertificateEntities { get; set; }
    }

}
