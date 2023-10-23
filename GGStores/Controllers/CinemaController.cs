using GGStores.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GGStores.Controllers
{
    public class CinemaController : Controller
    {
        private readonly StoreDbContext _storeContext;
        public CinemaController(StoreDbContext storeDbContext)
        {
            _storeContext = storeDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var allCinemass = await _storeContext.cinema.ToListAsync();

            return View(allCinemass);
        }


    }
}
