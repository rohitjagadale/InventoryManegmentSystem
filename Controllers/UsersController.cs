using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using InventoryManegmentSystem3.Data;
using InventoryManegmentSystem3.Models;

namespace InventoryManegmentSystem3.Controllers
{
    public class UsersController : Controller
    {
        private  ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.users.ToListAsync());
        }
        public async Task<IActionResult> Sucess()
        {
            return View("Sucess");
        }


        // GET: Users/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
   
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( User user)
        {

            if (ModelState.IsValid)
            {
                _context.Add(user);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Sucess));
            }
            return View(user);



        }



        // GET: Users/Login
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(String email, String password)
        {
            var flag= _context.users.FirstOrDefault(x =>  x.Email == email &&
            x.Password == password);
            if (flag == null) {
                return View("Unsucessful");
            }
            else
            {
                return View("sucess","/Home/Index");
            }
            
        }
      
       
    }
}
