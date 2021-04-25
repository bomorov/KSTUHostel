using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebUI.Data;
using WebUI.Models;
using WebUI.Models.DTOs;

namespace WebUI.Interfaces
{
    public interface IHostelRepository
    {
        Task<List<HostelDto>> Get();
    }

    public class HostelRepository : IHostelRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _appEnvironment;

        public HostelRepository(ApplicationDbContext context, IMapper mapper, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _mapper = mapper;
            _appEnvironment = appEnvironment;
        }

        public async Task<List<HostelDto>> Get()
        {
            return await _mapper.ProjectTo<HostelDto>(_context.Hostels).ToListAsync();
        }

        public async Task<Hostel> Create(Hostel hostel)
        {
            _context.Hostels.Add(hostel);
            await _context.SaveChangesAsync();
            return hostel;
        }
    }
}