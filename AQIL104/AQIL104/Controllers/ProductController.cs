using AQIL104.DAL;
using AQIL104.Models;
using AQIL104.ModelsVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AQIL104.Controllers
{
    public class ProductController : Controller
    {


        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }



        //public IActionResult Index()
        //{
        //    return View();
        //}



        public IActionResult Detail(int id)
        {
            if (id == 0) return BadRequest();
            Product product = _context.Products.Include(p => p.Category).Include(p => p.ProductImages).FirstOrDefault(p => p.Id == id);
            List<Product> products = _context.Products.Include(p => p.Category).Include(p => p.ProductImages).Where(p => p.CategoryId == product.CategoryId && p.Id != product.Id).ToList();

            if (product == null) return NotFound();

            ProductVM vm = new ProductVM { Product = product, Products = products };

            return View(vm);
        }
    }

}
