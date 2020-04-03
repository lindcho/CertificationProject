﻿using System;

namespace CertificateProject.Core.Models
{
    public class CertificateEntity
    {
        public int Id { get; set; }
        public int SequenceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public byte[] Document { get; set; }

    }
}
