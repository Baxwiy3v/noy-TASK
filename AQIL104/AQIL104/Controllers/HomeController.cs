using Microsoft.AspNetCore.Mvc;
using AQIL104.Models;
using AQIL104.ModelsVM;
using AQIL104.DAL;
using Microsoft.EntityFrameworkCore;

namespace AQIL104.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {



            List<Product> products = _context.Products.Include(p => p.ProductImages).OrderByDescending(s => s.CountId).Take(8).ToList();
            List<Slide> slides = _context.Slides.OrderBy(s => s.Id).Take(3).ToList();
            List<Client> clients = _context.Clients.ToList();
            List<Blog> blogs = _context.Blogs.ToList();
            List<ProductImage> productImages=_context.ProductImages.ToList();

            HomeVM vm = new HomeVM { 
                Slides = slides, 
                Products = products,
                Clients = clients, 
                Blogs = blogs,
                ProductImages= productImages
            };

            return View(vm);


        }




		public IActionResult About()
        {
            return View();
        }
    }
}
