using Microsoft.AspNetCore.Mvc;
using Nest_Backend.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nest_Backend.Controllers
{
    public class ProductDetailController : Controller
    {
        readonly AppDbContext _context;
        public ProductDetailController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int id)
        {
            return View(await _context.Products.FindAsync(id));
        }
    }
}
