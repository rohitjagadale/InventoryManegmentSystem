using InventoryManegmentSystem3.Data;
using InventoryManegmentSystem3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManegmentSystem3.Controllers
{
    public class ItemController : Controller
    {

        private ApplicationDbContext _context;

        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }


        // GET: ItemController
        public ActionResult Index()
        {
            return View();
        }

  

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }



        public async Task<IActionResult> Sucess()
        {
            return View("Sucess");
        }

        // POST: ItemController/Create




        [HttpPost]
        public async Task<IActionResult> Create(Item item)
        {

            if (ModelState.IsValid)
            {
                _context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Sucess));
            }
            return View(item);



        }




    }
}
