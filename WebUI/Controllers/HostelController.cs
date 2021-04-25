using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
            var applicationDbContext = _context.Hostels;

            ViewBag.Images = _context.Images;

            Hostel hostel = new Hostel();

            return View(hostel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Create(Hostel hostel, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hostel);
                await _context.SaveChangesAsync();

                try
                {
                    string directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files\\" + hostel.Id.ToString());
                    if (!Directory.Exists(directory))
                    {
                        DirectoryInfo di = Directory.CreateDirectory(directory);
                    }
                    int order = 1;
                    foreach (var item in files)
                    {
                        string fileName = item.FileName;
                        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", directory, fileName);
                        var memory = new MemoryStream();
                        using (var stream = new FileStream(path, FileMode.Create))
                        {
                            await item.CopyToAsync(stream);
                        }
                        memory.Position = 0;
                        string fpath = "/Files/" + hostel.Id.ToString() + "/" + fileName;
                        _context.Images.Add(new Image { HostelId = hostel.Id, Path = fpath, CreateDate = DateTime.Now, FileName = fileName, OrderBy = order });
                        await _context.SaveChangesAsync();
                        if (order == 1) { hostel.Map = fpath; await _context.SaveChangesAsync(); }
                        order++;
                    }
                }
                catch
                {
                    ViewBag.Error = "Error";
                    return View();
                }
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
            if (hostel == null)
            {
                return NotFound();
            }
            ViewBag.Images = _context.Images.Where(x => x.HostelId == id ).ToList();
            return View(hostel);
        }

    }
}