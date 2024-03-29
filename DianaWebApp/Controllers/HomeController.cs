﻿using DianaWebApp.DAL;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DianaWebApp.Controllers
{
    public class HomeController : Controller
    {
        AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {

            HomeVM vm = new HomeVM()
            {
                Products = await _db.Products.Include(p => p.ProductImages).ToListAsync(),
               
            };
            return View(vm);
        }
    }
}
