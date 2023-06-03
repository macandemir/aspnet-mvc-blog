using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class UserAdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
