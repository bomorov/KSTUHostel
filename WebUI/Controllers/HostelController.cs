using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebUI.Data;
using WebUI.Interfaces;

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
            //return View(await _context.Hostels.ToListAsync());
            return View(await _hostelRepository.Get());
        }
    }
}