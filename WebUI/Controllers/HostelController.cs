using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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

            ViewBag.NewsFilesNC = _context.NewsFilesNC;

            Hostel narodGerC = new Hostel();

            return View(narodGerC);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
       
        public async Task<IActionResult> Create(Hostel narodGerC, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                _context.Add(narodGerC);
                await _context.SaveChangesAsync();

                try
                {
                    string directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files\\" + narodGerC.Id.ToString());
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
                        string fpath = "/uploads/" + narodGerC.Id.ToString() + "/" + fileName;
                        _context.NewsFilesNC.Add(new NewsFilesNC() { HostelId = narodGerC.Id, Path = fpath, CreateDate = DateTime.Now, FileName = fileName, OrderBy = order });
                        await _context.SaveChangesAsync();
                        if (order == 1) { narodGerC.Map = fpath; await _context.SaveChangesAsync(); }
                        order++;
                    }
                }
                catch
                {
                    ViewBag.Error = "Oshibka";
                    return View();
                }
                return RedirectToAction(nameof(Index));
            }

            return View(narodGerC);
        }
    }
}