using System;
using System.ComponentModel.DataAnnotations;

namespace CertificateProject.Core.Domain
{
    public class Certificate
    {
        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public byte[] Document { get; set; }
    }
}
