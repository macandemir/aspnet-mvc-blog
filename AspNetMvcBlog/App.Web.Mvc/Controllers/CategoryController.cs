using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers
{
    public class CategoryController : Controller
    {
		public IActionResult LifeStyle(int id, int page)
		{
			return View();
		}
		public IActionResult Travel(int id, int page)
		{
			return View();
		}
		public IActionResult Weekends(int id, int page)
		{
			return View();
		}
		
	}
}