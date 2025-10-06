using Hung_Tran_Ngoc___66131218___Baitap1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Hung_Tran_Ngoc___66131218___Baitap1.Controllers
{
    public class ThamSoActionController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.tg = "Tran Ngoc Hung - 66131218 - điện thoại liên hệ: 0368392508";

            return View();
        }
        public IActionResult myRequest()
        {
            ViewBag.KQ= 77;
            return View();
        }
        public IActionResult myArgument(int a, int b)
        {
            ViewBag.KQ = a + b;
            return View();
        }
        public IActionResult myFormCollection(IFormCollection form)
        {
            int a = 0, b = 0;
            int.TryParse(form["a"], out a);
            int.TryParse(form["b"], out b);
            ViewBag.KQ = a + b;
            return View();
        }
        public IActionResult myModel(TongCls cal)
        {
            return View(cal);
        }
    }
}
