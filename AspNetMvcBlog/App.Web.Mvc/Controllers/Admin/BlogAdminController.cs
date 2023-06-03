using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class BlogAdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
