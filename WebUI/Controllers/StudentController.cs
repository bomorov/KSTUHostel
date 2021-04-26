using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebUI.Data;
using WebUI.Interfaces;
using WebUI.Models;
using WebUI.Models.Enums;

namespace WebUI.Controllers
{
    public class StudentController:Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly ApplicationDbContext _context;

        public StudentController(IStudentRepository studentRepository, ApplicationDbContext context)
        {
            _studentRepository = studentRepository;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _studentRepository.Get());
        }

        [HttpPost]
        public IActionResult UploadImage()
        {
            foreach (var file in Request.Form.Files)    
            {
                Student img = new Student();
                MemoryStream ms = new MemoryStream();
                file.CopyTo(ms);
                ms.Close();
                ms.Dispose();
                _context.Students.Add(img);
                _context.SaveChanges();
            }
            ViewBag.Message = "Файл загружен";
            return View("Index");
        }

        [HttpPost]
        public ActionResult RetrieveImage()
        {
            Student img = _context.Students.OrderByDescending(i => i.Id).SingleOrDefault();

            return View("Index");
        }
        public IActionResult Create(int id)
        {
            ViewBag.Avatars = _context.Avatars;

            _studentRepository.Create(id);

            ViewData["RegionOrCityId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.RegionAndCity), "Id", "Name");
            ViewData["DistrictOrCityId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.District), "Id", "Name");
            ViewData["CountrysideOrCityId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.Countryside), "Id", "Name");
            ViewData["VillageId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.Village), "Id", "Name");


            return View(_studentRepository.Create(id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Student student, List<IFormFile> files)
        {
            if (ModelState.IsValid)
            {
                ViewData["CountrysideOrCityId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.Countryside), "Id", "Name", student.CountrysideOrCityId);
                ViewData["DistrictOrCityId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.District), "Id", "Name", student.DistrictOrCityId);
                ViewData["RegionOrCityId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.RegionAndCity), "Id", "Name", student.RegionOrCityId);
                ViewData["VillageId"] = new SelectList(_context.CoateRecords.Where(x => x.CoateType == CoateType.Village), "Id", "Name", student.VillageId);

                await _studentRepository.Create(student, files);
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }


        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);

            if (student == null)
            {
                return NotFound();
            }
            ViewBag.Avatars = _context.Avatars.Where(x => x.StudentId == id).ToList();
            return View(student);
        }
        public IActionResult getCoate(int? id)
        {
            return Json(new SelectList(_context.CoateRecords.Where(e => e.ParentId == id).ToList(), "Id", "Name"));
        }
    }
}
