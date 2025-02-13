using Microsoft.AspNetCore.Mvc;

namespace DemoMVC.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            if (email == "admin@example.com" && password == "123456")
            {
                ViewBag.Message = "Đăng nhập thành công!";
                return RedirectToAction("Index", "Home");
            }
            
            ViewBag.Message = "Sai email hoặc mật khẩu!";
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                ModelState.AddModelError("", "Mật khẩu xác nhận không khớp.");
                return View();
            }

            ViewBag.Message = $"Đăng ký thành công! Email: {email}";
            return View();
        }
    }
}
