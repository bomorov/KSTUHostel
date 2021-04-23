using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebUI.Data;
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

        public HostelRepository(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<HostelDto>> Get()
        {
            return await _mapper.ProjectTo<HostelDto>(_context.Hostels).ToListAsync();
        }
    }
}