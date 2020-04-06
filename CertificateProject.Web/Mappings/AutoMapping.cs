using AutoMapper;
using CertificateProject.Core.Domain;

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
