using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class HomeAdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
