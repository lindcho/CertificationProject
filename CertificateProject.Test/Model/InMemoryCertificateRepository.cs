using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CertificateProject.Core.Domain;
using CertificateProject.Core.Interfaces;

namespace CertificateProject.Test.Model
{
    public class InMemoryCertificateRepository : ICertificateRepository
    {
        private readonly IList<Certificate> _db = new List<Certificate>();

        public void AddCertificate(Certificate certificate)
        {
            _db.Add(certificate);
        }

        public void DeleteCertificate(int id)
        {
            _db.Remove(GetCertificateById(id));
        }

        public void UpdateCertificate(Certificate certificate)
        {
            if (_db.Any(x => x.Id == certificate.Id))
            {
                _db.Remove(GetCertificateById(certificate.Id));
                _db.Add(certificate);
            }
        }

        public IEnumerable<Certificate> GetAllCertificates()
        {
            return _db.ToList();
        }

        public Certificate GetCertificateById(int id)
        {
            return _db.FirstOrDefault(x => x.Id == id);
        }
    }

}
