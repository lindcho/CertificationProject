using System;
using System.Collections.Generic;
using System.Text;
using CertificateProject.Core.Domain;
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

        public DbSet<Certificate> Certificate { get; set; }
    }

}
