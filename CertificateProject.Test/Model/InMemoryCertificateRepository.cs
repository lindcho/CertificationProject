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

        public void Add(Certificate certificate)
        {
            _db.Add(certificate);
        }

        public void Delete(int id)
        {
            _db.Remove(GetById(id));
        }

        public void Edit(Certificate certificate)
        {
            if (_db.Any(x => x.Id == certificate.Id))
            {
                _db.Remove(GetById(certificate.Id));
                _db.Add(certificate);
            }
        }

        public IEnumerable<Certificate> GetAll()
        {
            return _db.ToList();
        }

        public Certificate GetById(int id)
        {
            return _db.FirstOrDefault(x => x.Id == id);
        }
    }

}
