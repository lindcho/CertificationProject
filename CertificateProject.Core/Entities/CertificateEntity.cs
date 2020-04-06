using System;
using System.ComponentModel.DataAnnotations;

namespace CertificateProject.Infrastructure.Entities
{
    public class CertificateEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int SequenceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public byte[] Document { get; set; }

    }
}
