using GGStores.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GGStores.Controllers
{
    public class ProducerController : Controller
    {
        private readonly StoreDbContext _storeContext;
        public ProducerController(StoreDbContext storeDbContext)
        {
            _storeContext = storeDbContext;
        }
        public async Task<IActionResult> Index()
        {
            var producers = await _storeContext.producer.ToListAsync();

            return View(producers);
        }
    }
}
