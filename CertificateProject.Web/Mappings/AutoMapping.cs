using AutoMapper;
using CertificateProject.Core.Domain;
using CertificateProject.Infrastructure.Entities;

namespace CertificateProject.Web.Mappings
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<Certificate, CertificateEntity>();
            CreateMap<CertificateEntity, Certificate>();
        }
    }
}
