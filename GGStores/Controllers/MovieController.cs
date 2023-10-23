using GGStores.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GGStores.Controllers
{
	public class MovieController : Controller
	{
		private readonly StoreDbContext _storeContext;
		public MovieController(StoreDbContext storeDbContext)
		{
			_storeContext = storeDbContext;
		}
		public async Task<IActionResult> Index()
		{
			var allMovies = await _storeContext.Movie.Include(n => n.Cinema).OrderBy(n => n.Name).ToListAsync();

			return View(allMovies);
		}
	}
}
