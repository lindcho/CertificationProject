using System.Collections.Generic;
using CertificateProject.Core.Models;

namespace CertificateProject.Core.Repository
{
    public interface ICertificateRepository
    {
        IEnumerable<CertificateEntity> GetAll();
        CertificateEntity GetById(int id);
        void Insert(CertificateEntity employee);
        void Update(CertificateEntity employee);
        void Delete(int id);
        void Save();

    }
}
