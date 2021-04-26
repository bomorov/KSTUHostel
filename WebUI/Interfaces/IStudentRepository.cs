using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using WebUI.Data;
using WebUI.Models;
using WebUI.Models.DTOs;

namespace WebUI.Interfaces
{
    public interface IStudentRepository
    {
        Student Create(int id);

        Task<Student> Create(Student student, List<IFormFile> files);

        Task<List<StudentDto>> Get();
    }

    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public async Task<List<StudentDto>> Get()
        {
            return await _mapper.ProjectTo<StudentDto>(_context.Students).ToListAsync();
        }

        public StudentRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Student Create(int id)
        {
            Student student = new Student();
            return student;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<Student> Create(Student student, List<IFormFile> files)
        {
            _context.Add(student);
            await _context.SaveChangesAsync();

            try
            {
                string directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files\\Students\\" + student.Id.ToString());
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
                    string fpath = "/Files/Students/" + student.Id.ToString() + "/" + fileName;
                    _context.Avatars.Add(new Avatar { StudentId = student.Id, Path = fpath, CreateDate = DateTime.Now, FileName = fileName, OrderBy = order });
                    await _context.SaveChangesAsync();
                    if (order == 1) { student.Path = fpath; await _context.SaveChangesAsync(); }
                    order++;
                }
            }
            catch
            {
                return student;
            }

            return student;
        }
    }
}