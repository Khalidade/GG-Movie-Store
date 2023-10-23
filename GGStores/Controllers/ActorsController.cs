using GGStores.Data.Interface;
using GGStores.Models;
using Microsoft.AspNetCore.Mvc;

namespace GGStores.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorsService;

        public ActorsController(IActorsService actorsService)
        {
            _actorsService = actorsService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actorsService.GetAllAsync();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePicture,Bio")] ActorModel actor)
        {



            if (!ModelState.IsValid)
            {
                return View(actor);
            }

            await _actorsService.AddAsync(actor);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);


            if (actorDetails == null)
            {
                return View("NotFound");
            }
            return View(actorDetails);


        }


        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }



        [HttpPost]
        public async Task<IActionResult> Edit(int id, ActorModel request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }

            await _actorsService.UpdateAsync(id, request);
            return RedirectToAction(nameof(Index));


        }
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _actorsService.GetByIdAsync(id);
            if (actorDetails == null) return View("Notfound");
            return View(actorDetails);
        }



        [HttpPost]
        public async Task<IActionResult> DeleteAsync(int id)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            await _actorsService.DeleteAsync(id);

            return RedirectToAction(nameof(Index));


        }
    }
}
