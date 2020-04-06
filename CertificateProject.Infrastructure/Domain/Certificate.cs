using System;
using System.ComponentModel.DataAnnotations;

namespace CertificateProject.Core.Domain
{
    public class Certificate
    {
        [Key]
        public int Id { get; set; }
        //TODO Add unique constraint
        public int SequenceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        //TODO add code to upload document at repository level
        public byte[] Document { get; set; }
    }
}
