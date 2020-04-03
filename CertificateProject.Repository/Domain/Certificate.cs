using System;
using System.Collections.Generic;
using System.Text;

namespace CertificateProject.Core.Models
{
    public class Certificate
    {
        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public byte[] Document { get; set; }
    }
}
