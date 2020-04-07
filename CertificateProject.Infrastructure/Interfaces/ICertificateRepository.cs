using System.Collections.Generic;
using CertificateProject.Core.Domain;

namespace CertificateProject.Core.Interfaces
{
    public interface ICertificateRepository
    {
        IEnumerable<Certificate> GetAllCertificates();
        Certificate GetCertificateById(int id);
        void AddCertificate (Certificate certificate);
        void UpdateCertificate(Certificate certificate);
        void DeleteCertificate(int id);
    }
}
