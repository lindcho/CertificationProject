using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CertificateProject.Core.Domain;
using CertificateProject.Core.Interfaces;

namespace CertificateProject.Web.Controllers
{
    public class CertificatesController : Controller
    {
        private readonly ICertificateRepository _repository;

        public CertificatesController(ICertificateRepository repository)
        {
            _repository = repository;
        }

        // GET: Certificates
        public IActionResult Index()
        {
            var certificates = _repository.GetAll();

            return View(certificates);
        }

        // GET: Certificates/Details/5
        public IActionResult Details(int id)
        {
            var certificate = _repository.GetById(id);
            if (certificate == null)
            {
                return NotFound();
            }
            return View(certificate);
        }

        // GET: Certificates/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Certificates/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,SequenceNumber,IssueDate,Document")] Certificate certificate)
        {
            if (ModelState.IsValid)
            {

                _repository.Add(certificate);
                return RedirectToAction(nameof(Index));
            }
            return View(certificate);
        }

        // GET: Certificates/Edit/5
        public IActionResult Edit(int id)
        {
            var certificate = _repository.GetById(id);
            if (certificate == null)
            {
                return NotFound();
            }
            return View(certificate);
        }

        // POST: Certificates/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,SequenceNumber,IssueDate,Document")] Certificate certificate)
        {
            if (id != certificate.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid) return View(certificate);
            try
            {
                _repository.Edit(certificate);
            }
            catch (DbUpdateConcurrencyException)
            {
            }
            return RedirectToAction(nameof(Index));
        }

        // GET: Certificates/Delete/5
        public IActionResult Delete(int id)
        {
            var certificate = _repository.GetById(id);
            if (certificate == null)
            {
                return NotFound();
            }
            return View(certificate);
        }

        // POST: Certificates/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _repository.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
