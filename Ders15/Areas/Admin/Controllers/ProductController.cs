using Microsoft.AspNetCore.Mvc;

namespace Ders15.Areas.Admin.Controllers
{
	[Area("Admin")]
	public class ProductController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
