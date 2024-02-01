using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;

namespace MvcMovie.Controllers
{
    public class RoomController : Controller
    {
        private readonly MvcMoviesContext _context;

        public RoomController(MvcMoviesContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Room.ToListAsync());
        }
    }
}
