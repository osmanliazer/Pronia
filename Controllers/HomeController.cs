using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplicationPronia.DataAccesLayer;
using WebApplicationPronia.Models;
using WebApplicationPronia.ViewModels.Categories;

namespace WebApplicationPronia.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaContext _context;

        public HomeController(ProniaContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _context.Categories
                .Where(x => x.IsDelete == false)
                .Select(x => new GetCategoryVM
                {
                    Id = x.Id,
                    Name = x.Name,
                })
            .ToListAsync();
            return View(data);
        }

        public async Task<IActionResult> Contact()
        {
            return View();
        }

        public async Task<IActionResult> Test(int? id)
        {
            if (id==null || id<1) return BadRequest();
            var cat= await _context.Categories.FindAsync(id);
            if (cat==null)
            {
                return NotFound();
            }
            _context.Remove(cat);
            await _context.SaveChangesAsync();
            return Content(cat.Name);


            //Category cat = new Category
            //{
            //    Name = name,
            //    CreatedTime = DateTime.Now,
            //    IsDelete = false,
            //};
            //await _context.Categories.AddAsync(cat);
            //await _context.SaveChangesAsync();
            //return Content(cat);
        }
    }
}
