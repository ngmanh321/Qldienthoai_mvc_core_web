using BTL_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using BTL_Web.Models.Authenlication;
using X.PagedList;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTL_Web.Controllers
{
    public class HomeController : Controller
    {
        QldienthoaiContext db = new QldienthoaiContext();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Authentication]
        public IActionResult Index(int? page)
        {
            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var lstsanpham = db.Sanphams.AsNoTracking().OrderBy(x => x.Tensp);
            PagedList<Sanpham> lst = new PagedList<Sanpham>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]
        public IActionResult Products(int? page)
        {
            int pageSize = 12;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var lstsanpham = db.Sanphams.AsNoTracking().OrderBy(x => x.Tensp);
            PagedList<Sanpham> lst = new PagedList<Sanpham>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]

        public IActionResult SanPhamTheoLoai(int mahang, int? page)
        {


            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var lstsanpham = db.Sanphams.AsNoTracking().Where(x => x.Mahang == mahang).OrderBy(x => x.Tensp);
            PagedList<Sanpham> lst = new PagedList<Sanpham>(lstsanpham, pageNumber, pageSize);

            ViewBag.mahang = mahang;

            return View(lst);
        }
        [Authentication]

        public IActionResult SanPhamTheoHdh(int mahdh, int? page)
        {


            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var lstsanpham = db.Sanphams.AsNoTracking().Where(x => x.Mahdh == mahdh).OrderBy(x => x.Tensp);
            PagedList<Sanpham> lst = new PagedList<Sanpham>(lstsanpham, pageNumber, pageSize);

            ViewBag.mahdh = mahdh;

            return View(lst);
        }

        [Authentication]

        public IActionResult SanPhamTheoMh(string mamanhinh, int? page)
        {


            int pageSize = 8;
            int pageNumber = page == null || page < 0 ? 1 : page.Value;

            var lstsanpham = db.Sanphams.AsNoTracking().Where(x => x.Mamanhinh == mamanhinh).OrderBy(x => x.Tensp);
            PagedList<Sanpham> lst = new PagedList<Sanpham>(lstsanpham, pageNumber, pageSize);

            ViewBag.mamanhinh = mamanhinh;

            return View(lst);
        }

        [Authentication]

        public IActionResult ChiTietSanPham(int masp)
        {
            var sanpham = db.Sanphams.SingleOrDefault(x => x.Masp == masp);
            ViewBag.sanpham = sanpham;
            return View(sanpham);

        }

        [Authentication]

        public IActionResult MuaSanPham(int masp)
        {

            var sanpham = db.Sanphams.SingleOrDefault(x => x.Masp == masp);
            ViewBag.sanpham = sanpham;
            return View(sanpham);

        }

        [Authentication]
        public IActionResult DonHang()
        {
            return View();

        }

        [Authentication]
        public IActionResult LichSuDonHang()
        {
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