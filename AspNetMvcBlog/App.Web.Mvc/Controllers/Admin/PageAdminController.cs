using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class PageAdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
