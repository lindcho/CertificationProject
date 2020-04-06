using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using CertificateProject.Core.Domain;
using CertificateProject.Core.Interfaces;
using CertificateProject.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace CertificateProject.Infrastructure.Repository
{
    public class CertificateRepository : ICertificateRepository
    {
        private readonly CertificateContext _certificateContext;
        private readonly IMapper _mapper;

        public CertificateRepository(CertificateContext certificateContext, IMapper mapper)
        {
            _certificateContext = certificateContext;
            _mapper = mapper;
        }

        public IEnumerable<Certificate> GetAll()
        {
            var certificateEntities = _certificateContext.CertificateEntities.ToList();
            var certificates = _mapper.Map<IEnumerable<Certificate>>(certificateEntities);
            return certificates;
        }

        public Certificate GetById(int id)
        {
            var certificateEntity = _certificateContext.CertificateEntities.Find(id);
            var certificate = _mapper.Map<Certificate>(certificateEntity);
            return certificate;
        }

        public void Add(Certificate certificate)
        {
            var certificateEntity = _mapper.Map<CertificateEntity>(certificate);

            _certificateContext.CertificateEntities.Add(certificateEntity);
            _certificateContext.SaveChanges();
        }

        public void Edit(Certificate certificate)
        {
            var certificateEntity = _mapper.Map<CertificateEntity>(certificate);

            _certificateContext.Entry(certificateEntity).State = EntityState.Modified;
            _certificateContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var certificate = GetById(id);
            var certificateEntity = _mapper.Map<CertificateEntity>(certificate);

            _certificateContext.CertificateEntities.Remove(certificateEntity);
            _certificateContext.SaveChanges();
        }

    }
}
