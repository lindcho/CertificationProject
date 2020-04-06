using System.Collections.Generic;
using CertificateProject.Core.Domain;

namespace CertificateProject.Core.Interfaces
{
    public interface ICertificateRepository
    {
        IEnumerable<Certificate> GetAll();
        Certificate GetById(int id);
        void Add (Certificate certificate);
        void Edit(Certificate certificate);
        void Delete(int id);
    }
}
