using AutoMapper;
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
    public interface IHostelRepository
    {
        Task<List<HostelDto>> Get();

        Hostel Create(int id);

        Task<Hostel> Create(Hostel hostel, List<IFormFile> files);

        Task<HostelDto> Get(int? id);
    }

    public class HostelRepository : IHostelRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;


        public HostelRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<HostelDto>> Get()
        {
            return await _mapper.ProjectTo<HostelDto>(_context.Hostels).ToListAsync();
        }

        public Hostel Create(int id)
        {
            Hostel hostel = new Hostel();
            return hostel;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<Hostel> Create(Hostel hostel, List<IFormFile> files)
        {
            _context.Add(hostel);
            await _context.SaveChangesAsync();

            try
            {
                string directory = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\Files\\Hostels\\" + hostel.Id.ToString());
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
                    string fpath = "/Files/Hostels/" + hostel.Id.ToString() + "/" + fileName;
                    _context.Images.Add(new Image { HostelId = hostel.Id, Path = fpath, CreateDate = DateTime.Now, FileName = fileName, OrderBy = order });
                    await _context.SaveChangesAsync();
                    if (order == 1) { hostel.Map = fpath; await _context.SaveChangesAsync(); }
                    order++;
                }
            }
            catch
            {
                return hostel;
            }

            return hostel;
        }

        public async Task<HostelDto> Get(int? id)
        {
            return await _mapper.ProjectTo<HostelDto>(_context.Hostels).FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}