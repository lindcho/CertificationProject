using System.Collections.Generic;
using System.Linq;
using CertificateProject.Core.Domain;
using CertificateProject.Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CertificateProject.Infrastructure.Repository
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly CertificateContext _db;

        public CertificateRepository(CertificateContext db)
        {
            _db = db;
        }

        public IEnumerable<Certificate> GetAll()
        {
            return _db.Certificate.ToList();
        }

        public Certificate GetById(int id)
        {
            var result = _db.Certificate.Find(id);
            return result;
        }

        public void Add(Certificate certificate)
        {
            _db.Certificate.Add(certificate);
            _db.SaveChanges();
        }

        public void Edit(Certificate certificate)
        {
            _db.Entry(certificate).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            var certificate = GetById(id);
            _db.Certificate.Remove(certificate);
            _db.SaveChanges();
        }

    }
}
