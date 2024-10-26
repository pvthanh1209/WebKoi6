using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebKoi6.BLL.InterfaceBLL;
using WebKoi6.Models;

namespace WebKoi6.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBacsiBLL _bacsiBLL;
        public HomeController(IBacsiBLL bacsiBLL)
        {
            _bacsiBLL = bacsiBLL;
        }

        public IActionResult Index()
        {
           var data = _bacsiBLL.GetAll();
            return View();
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
