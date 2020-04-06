using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CertificateProject.Core.Domain;
using CertificateProject.Test.Model;
using NUnit.Framework;

namespace CertificateProject.Test.Domain
{
    public class CertificateRepository
    {
        [Test]
        public void GetAll_returns_a_list_of_the_existing_certificates()
        {
            var repository = new InMemoryCertificateRepository();
            repository.Add(MakeCertificate(1, 2225));
            repository.Add(MakeCertificate(2, 2226));

            var certificates = repository.GetAll();
            var result = certificates;

            Assert.That(result.Count(), Is.EqualTo(2));
        }


        private static Certificate MakeCertificate(int id, int seqNo)
        {
            return new Certificate { Id = id, SequenceNumber = seqNo, IssueDate = DateTime.Now, Document = null };
        }
    }
}
