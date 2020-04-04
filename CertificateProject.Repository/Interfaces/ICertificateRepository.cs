using System.Collections.Generic;
using CertificateProject.Core.Domain;

namespace CertificateProject.Core.Interfaces
{
    public interface ICertificateRepository
    {
        IEnumerable<CertificateEntity> GetAll();
        CertificateEntity GetById(int id);
        void Add (CertificateEntity certificateEntity);
        void Edit(CertificateEntity certificateEntity);
        void Delete(int id);
        void Save();

    }
}
