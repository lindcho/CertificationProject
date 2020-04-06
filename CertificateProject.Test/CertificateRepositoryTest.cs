using System;
using System.Linq;
using CertificateProject.Core.Domain;
using CertificateProject.Infrastructure;
using CertificateProject.Infrastructure.Repository;
using NUnit.Framework;
using Microsoft.EntityFrameworkCore;

namespace CertificateProject.Test
{
    [TestFixture]
    [Category("Acceptance")]
    public class CertificateRepositoryTest
    {
        //private CertificateRepository _repo;

        //[SetUp]
        //public void TestSetup()
        //{
        //    var optionsBuilder = BuildDbConnection();
        //    var certificateContext = new CertificateContext(optionsBuilder.Options);
        //    _repo = new CertificateRepository(certificateContext);
        //}

        //private static DbContextOptionsBuilder<CertificateContext> BuildDbConnection()
        //{
        //    var optionsBuilder = new DbContextOptionsBuilder<CertificateContext>();
        //    optionsBuilder.UseSqlServer(
        //        "Server=(localdb)\\mssqllocaldb;Database=Certification;Trusted_Connection=True;MultipleActiveResultSets=true");
        //    return optionsBuilder;
        //}

        //[Test]
        //[Ignore("need to manually run")]
        //public void IsRepositoryInitializedWithValidNumberOfData()
        //{
        //    var result = _repo.GetAll();
        //    Assert.IsNotNull(result);
        //    var numberOfRecords = result.ToList().Count;
        //    Assert.AreEqual(6, numberOfRecords);
        //}

        //[Test]
        //[Ignore("manually run")]
        //public void Add_GivenTwoRecordsInDb_ShouldAddCertificateAndIncreaseRecordCount()
        //{
        //    Certificate certificateToInsert = new Certificate
        //    {
        //        SequenceNumber = 1112,
        //        IssueDate = DateTime.Now,
        //        Document = null
        //    };
        //    _repo.Add(certificateToInsert);
        //    var result = _repo.GetAll();
        //    var numberOfRecords = result.ToList().Count;
        //    Assert.AreEqual(6, numberOfRecords);
        //}

    }
}