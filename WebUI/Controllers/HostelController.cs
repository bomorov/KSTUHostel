using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebUI.Data;
using WebUI.Interfaces;
using WebUI.Models;

namespace WebUI.Controllers
{
    public class HostelController : Controller
    {
        private readonly IHostelRepository _hostelRepository;
        private readonly ApplicationDbContext _context;

        public HostelController(IHostelRepository hostelRepository, ApplicationDbContext context)
        {
            _hostelRepository = hostelRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _hostelRepository.Get());
        }

        [HttpPost]
        public IActionResult UploadImage()
        {
            foreach (var file in Request.Form.Files)
            {
                Hostel img = new Hostel();
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                ms.Close();
                ms.Dispose();
                _context.Hostels.Add(img);
                _context.SaveChanges();
            }
            ViewBag.Message = "Файл загружен";
            return View("Index");
        }

        [HttpPost]
        public ActionResult RetrieveImage()
        {
            Hostel img = _context.Hostels.OrderByDescending(i => i.Id).SingleOrDefault();

            return View("Index");
        }

        public IActionResult Create(int id)
        {
            ViewBag.Images = _context.Images;

            _hostelRepository.Create(id);

            return View(_hostelRepository.Create(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Hostel hostel, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                await _hostelRepository.Create(hostel, files);
                return RedirectToAction(nameof(Index));
            }

            return View(hostel);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hostel = await _context.Hostels
                .FirstOrDefaultAsync(m => m.Id == id);
            //var hostel = await _hostelRepository.Get(id);
            if (hostel == null)
            {
                return NotFound();
            }
            ViewBag.Images = _context.Images.Where(x => x.HostelId == id).ToList();
            return View(hostel);
        }
    }
}