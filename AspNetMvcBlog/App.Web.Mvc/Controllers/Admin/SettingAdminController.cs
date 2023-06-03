using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Controllers.Admin
{
    public class SettingAdminController : BaseAdminController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
