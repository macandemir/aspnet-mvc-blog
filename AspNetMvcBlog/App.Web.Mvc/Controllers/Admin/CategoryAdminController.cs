using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class CategoryAdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
