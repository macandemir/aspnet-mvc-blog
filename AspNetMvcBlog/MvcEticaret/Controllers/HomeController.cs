using Microsoft.AspNetCore.Mvc;
using MvcEticaret.Models;
using System.Diagnostics;

namespace MvcEticaret.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var products = new List<Product>();

            products.Add(new Product() { Title = "Ürün 1", IsSale = false, OldPrice = 100, StarCount = 0, ImageUrl = "https://fastly.picsum.photos/id/26/4209/2769.jpg?hmac=vcInmowFvPCyKGtV7Vfh7zWcA_Z0kStrPDW3ppP0iGI", Price = 50 });
            products.Add(new Product() { Title = "Ürün 2", IsSale = false, OldPrice = 90, StarCount = 0, ImageUrl = "https://fastly.picsum.photos/id/21/3008/2008.jpg?hmac=T8DSVNvP-QldCew7WD4jj_S3mWwxZPqdF0CNPksSko4", Price = 85 });
            products.Add(new Product() { Title = "Ürün 3", IsSale = true, OldPrice = 20, StarCount = 2, ImageUrl = "https://fastly.picsum.photos/id/30/1280/901.jpg?hmac=A_hpFyEavMBB7Dsmmp53kPXKmatwM05MUDatlWSgATE", Price = 5 });
            products.Add(new Product() { Title = "Ürün 4", IsSale = true, OldPrice = 80, StarCount = 5, ImageUrl = "https://fastly.picsum.photos/id/48/5000/3333.jpg?hmac=y3_1VDNbhii0vM_FN6wxMlvK27vFefflbUSH06z98so", Price = 50 });
            products.Add(new Product() { Title = "Ürün 5", IsSale = false, OldPrice = 40, StarCount = 0, ImageUrl = "https://fastly.picsum.photos/id/91/3504/2336.jpg?hmac=tK6z7RReLgUlCuf4flDKeg57o6CUAbgklgLsGL0UowU", Price = 25 });
            products.Add(new Product() { Title = "Ürün 6", IsSale = true, OldPrice = 500, StarCount = 3, ImageUrl = "https://fastly.picsum.photos/id/96/4752/3168.jpg?hmac=KNXudB1q84CHl2opIFEY4ph12da5JD5GzKzH5SeuRVM", Price = 420 });
            products.Add(new Product() { Title = "Ürün 7", IsSale = false, OldPrice = 25, StarCount = 0, ImageUrl = "https://fastly.picsum.photos/id/119/3264/2176.jpg?hmac=PYRYBOGQhlUm6wS94EkpN8dTIC7-2GniC3pqOt6CpNU", Price = 10 });
			products.Add(new Product() { Title = "Ürün 7", IsSale = false, OldPrice = 70, StarCount = 0, ImageUrl = "https://fastly.picsum.photos/id/175/2896/1944.jpg?hmac=djMSfAvFgWLJ2J3cBulHUAb4yvsQk0d4m4xBJFKzZrs", Price = 50 });

			return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}