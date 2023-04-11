using BTL_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BTL_Web.Models.Authenlication;

namespace BTL_Web.Controllers
{
    public class AccessController : Controller
    {
        QldienthoaiContext db = new QldienthoaiContext();
        //public IActionResult Index()
        //{
        //    return View();
        //}


        [HttpGet]
        public IActionResult Login()
        {
            if (HttpContext.Session.GetString("DN") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        [HttpPost]
        public IActionResult Login(Nguoidung user)
        {
            if (HttpContext.Session.GetString("DN") == null)
            {
                var u = db.Nguoidungs.Where(x => x.TenTk == user.TenTk && x.MatKhau == user.MatKhau).FirstOrDefault();


                if (u != null)
                {
                    HttpContext.Session.SetString("TK", u.TenTk.ToString());

                    var loaiTK = u.LoaiTk;
                    if (loaiTK == "1")
                    {
                        Console.WriteLine(user.LoaiTk);
                        HttpContext.Session.SetString("DN", u.TenTk.ToString());

                        //return RedirectToAction("HomeAdmin","Admin");
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        Console.WriteLine(user.LoaiTk);
                        HttpContext.Session.SetString("DN", u.TenTk.ToString());
                        HttpContext.Session.SetString("DNAd", u.LoaiTk.ToString());

                        return RedirectToAction("HomeAdmin","Admin");
                    }


                }


            }
            return View(user);
        }


        public IActionResult Sigup()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            HttpContext.Session.Remove("DN");
            return RedirectToAction("Login", "Access");
        }


    }
}
