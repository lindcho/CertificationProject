using System;
using System.Collections.Generic;
using System.Text;
using CertificateProject.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace CertificateProject.Infrastructure
{
    public class CertificateInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Certificate>().HasData(
                new Certificate
                {
                    Id = 1,
                    SequenceNumber = 1110,
                    IssueDate = new DateTime(2020, 01, 20)
                },
                new Certificate
                {
                    Id = 2,
                    SequenceNumber = 1111,
                    IssueDate = new DateTime(2020, 03, 01)
                }
            );
        }
    }
}
