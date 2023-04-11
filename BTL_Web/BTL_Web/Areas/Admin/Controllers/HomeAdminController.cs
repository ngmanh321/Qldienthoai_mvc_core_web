using BTL_Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BTL_Web.Models.Authenlication;
using X.PagedList;
using Microsoft.AspNetCore.Hosting;

namespace BTL_Web.Areas.Admin.Controllers
{
    [Area("admin")]
    [Route("admin/homeadmin")]
    [Route("admin")]

    public class HomeAdminController : Controller
    {

        QldienthoaiContext db = new QldienthoaiContext();

        [Route("")]
        [Route("index")]

        [Authentication]
        [Authentication_Ad]

        public IActionResult Index()
        {
            List<Sanpham> lstSanPham = db.Sanphams.OrderBy(x => x.Tensp).ToList();
            return View(lstSanPham);
        }

        [Authentication]
        [Authentication_Ad]

        [Route("danhmucsanpham")]
        public IActionResult DanhMucSanPham(int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            int pageSize = 12;
            var lstsanpham = db.Sanphams.AsNoTracking().OrderBy(x => x.Tensp).ToList();
            PagedList<Sanpham> lst = new PagedList<Sanpham>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]
        [Authentication_Ad]

        [Route("danhmuchangsx")]
        public IActionResult DanhMucHangSX(int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            int pageSize = 12;
            var lstsanpham = db.Hangsanxuats.AsNoTracking().OrderBy(x => x.Tenhang).ToList();
            PagedList<Hangsanxuat> lst = new PagedList<Hangsanxuat>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]
        [Authentication_Ad]

        [Route("danhmuchdh")]
        public IActionResult DanhMucHDH(int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            int pageSize = 12;
            var lstsanpham = db.Hedieuhanhs.AsNoTracking().OrderBy(x => x.Tenhdh).ToList();
            PagedList<Hedieuhanh> lst = new PagedList<Hedieuhanh>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]
        [Authentication_Ad]

        [Route("danhmucmanhinh")]
        public IActionResult DanhMucManHinh(int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            int pageSize = 12;
            var lstsanpham = db.Manhinhs.AsNoTracking().OrderBy(x => x.Tenmanhinh).ToList();
            PagedList<Manhinh> lst = new PagedList<Manhinh>(lstsanpham, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]
        [Authentication_Ad]
        [Route("danhmuctaikhoan")]
        public IActionResult DanhMucTaiKhoan(int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            int pageSize = 12;
            var lsthang = db.Nguoidungs.AsNoTracking().OrderBy(x => x.TenTk).ToList();
            PagedList<Nguoidung> lst = new PagedList<Nguoidung>(lsthang, pageNumber, pageSize);
            return View(lst);
        }

        [Authentication]
        [Authentication_Ad]
        [Route("danhmucdonhang")]
        public IActionResult DanhMucDonHang(int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            int pageSize = 12;
            var lsthang = db.Chitietdonhangs.AsNoTracking().OrderBy(x => x.Tensp).ToList();
            PagedList<Chitietdonhang> lst = new PagedList<Chitietdonhang>(lsthang, pageNumber, pageSize);
            return View(lst);
        }


        [Authentication]
        [Authentication_Ad]
        [Route("lichsudonhang")]
        public IActionResult LichSuDonHang(int? page)
        {
            int pageNumber = page == null || page < 0 ? 1 : page.Value;
            int pageSize = 12;
            var lsthang = db.Donhangs.AsNoTracking().OrderBy(x => x.Tensp).ToList();
            PagedList<Donhang> lst = new PagedList<Donhang>(lsthang, pageNumber, pageSize);
            return View(lst);
        }


        // Sua SP
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("SuaSanPham")]

        public IActionResult SuaSanPham(int maSp)
        {
            ViewBag.Mahang = new SelectList(db.Hangsanxuats, "Mahang", "Tenhang");
            ViewBag.Mahdh = new SelectList(db.Hedieuhanhs, "Mahdh", "Tenhdh");
            ViewBag.Mamanhinh = new SelectList(db.Manhinhs, "Mamanhinh", "Tenmanhinh");
            Sanpham sanPham = db.Sanphams.Find(maSp);
            return View(sanPham);
        }


        [Route("SuaSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaSanPham(Sanpham sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DanhMucSanPham");
            }

            return View(sanPham);
        }

        // Sua Hang SX
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("SuaHangSX")]

        public IActionResult SuaHangSX(int mahang)
        {
            Hangsanxuat sanPham = db.Hangsanxuats.Find(mahang);
            return View(sanPham);
        }


        [Route("SuaHangSX")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaHangSX(Hangsanxuat sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DanhMucHangSX");
            }

            return View(sanPham);
        }

        // Sua HDH
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("SuaHDH")]

        public IActionResult SuaHDH(int mahdh)
        {
            Hedieuhanh sanPham = db.Hedieuhanhs.Find(mahdh);
            return View(sanPham);
        }


        [Route("SuaHDH")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaHDH(Hedieuhanh sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DanhMucHDH");
            }

            return View(sanPham);
        }


        //Sua TK
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("SuaTaiKhoan")]

        public IActionResult SuaTaiKhoan(string tentk)
        {

            Nguoidung sanPham = db.Nguoidungs.Find(tentk);
            return View(sanPham);
        }


        [Route("SuaTaiKhoan")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SuaTaiKhoan(Nguoidung sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sanPham).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("DanhMucTaiKhoan");
            }

            return View(sanPham);
        }



        // Them SP
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("ThemSanPham")]

        public IActionResult ThemSanPham()
        {
            ViewBag.Mahang = new SelectList(db.Hangsanxuats, "Mahang", "Tenhang");
            ViewBag.Mahdh = new SelectList(db.Hedieuhanhs, "Mahdh", "Tenhdh");
            ViewBag.Mamanhinh = new SelectList(db.Manhinhs, "Mamanhinh", "Tenmanhinh");


            return View(new Sanpham());
        }



        [Route("ThemSanPham")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemSanPham(Sanpham sanPham)
        {

            db.Sanphams.Add(sanPham);
            db.SaveChanges();
            return RedirectToAction("DanhMucSanPham");

        }


        // Them Hang SX
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("ThemHangSX")]

        public IActionResult ThemHangSX()
        {

            return View(new Hangsanxuat());
        }



        [Route("ThemHangSX")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemHangSX(Hangsanxuat sanPham)
        {

            db.Hangsanxuats.Add(sanPham);
            db.SaveChanges();
            return RedirectToAction("DanhMucHangSX");

        }


        // Them HDH
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("ThemHDH")]

        public IActionResult ThemHDH()
        {

            return View(new Hedieuhanh());
        }



        [Route("ThemHDH")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemHDH(Hedieuhanh sanPham)
        {

            db.Hedieuhanhs.Add(sanPham);
            db.SaveChanges();
            return RedirectToAction("DanhMucHDH");

        }

        // Them TK
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("ThemTaiKhoan")]

        public IActionResult ThemTaiKhoan()
        {

            return View(new Nguoidung());
        }



        [Route("ThemTaiKhoan")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ThemTaiKhoan(Nguoidung sanPham)
        {

            db.Nguoidungs.Add(sanPham);
            db.SaveChanges();
            return RedirectToAction("DanhMucTaiKhoan");

        }

        // Xoa SP
        [Authentication]
        [Authentication_Ad]

        [Route("XoaSanPham")]
        [HttpGet]
        public IActionResult XoaSanPham(int maSp)
        {

            TempData["Message"] = "";
            var listChiTiet = db.Chitietdonhangs.Where(x => x.Masp == maSp);
            if (listChiTiet.Count() > 0)

            {

                TempData["Message"] = "Không xóa được sản phẩm này"; return RedirectToAction("DanhMucSanPham", "HomeAdmin");

            }


            db.Remove(db.Sanphams.Find(maSp));

            db.SaveChanges();

            TempData["Message"] = "Sản phẩm đã được xóa"; return RedirectToAction("DanhMucSanPham", "HomeAdmin");




        }

        // Xoa Hang SX
        [Authentication]
        [Authentication_Ad]

        [Route("XoaHangSX")]
        [HttpGet]
        public IActionResult XoaHangSX(int mahang)
        {

            TempData["Message"] = "";
            var listChiTiet = db.Sanphams.Where(x => x.Mahang == mahang);
            if (listChiTiet.Count() > 0)

            {

                TempData["Message"] = "Không xóa được hang SX này"; return RedirectToAction("DanhMuchangSX", "HomeAdmin");

            }


            db.Remove(db.Hangsanxuats.Find(mahang));

            db.SaveChanges();

            TempData["Message"] = "Hang SX đã được xóa"; return RedirectToAction("DanhMuchangSX", "HomeAdmin");

        }

        // Xoa HDH
        [Authentication]
        [Authentication_Ad]

        [Route("XoaHDH")]
        [HttpGet]
        public IActionResult XoaHDH(int mahdh)
        {

            TempData["Message"] = "";
            var listChiTiet = db.Sanphams.Where(x => x.Mahdh == mahdh);
            if (listChiTiet.Count() > 0)

            {

                TempData["Message"] = "Không xóa được HDH này"; return RedirectToAction("DanhMucHDH", "HomeAdmin");

            }


            db.Remove(db.Hedieuhanhs.Find(mahdh));

            db.SaveChanges();

            TempData["Message"] = "HDH đã được xóa"; return RedirectToAction("DanhMucHDH", "HomeAdmin");

        }

        // Xoa TK
        [Authentication]
        [Authentication_Ad]
        [Route("XoaTaiKhoan")]
        [HttpGet]
        public IActionResult XoaTaiKhoan(string tentk)
        {

            TempData["Message"] = "";
            var listChiTiet = db.Chitietdonhangs.Where(x => x.TenTK == tentk);
            if (listChiTiet.Count() > 0)

            {

                TempData["Message"] = "Không xóa được TK này"; return RedirectToAction("DanhMucTaiKhoan", "HomeAdmin");

            }


            db.Remove(db.Nguoidungs.Find(tentk));

            db.SaveChanges();

            TempData["Message"] = "TK đã được xóa"; return RedirectToAction("DanhMucTaiKhoan", "HomeAdmin");


        }


        // Xoa Lich Su Don hang
        [Authentication]
        [Authentication_Ad]
        [Route("XoaLSDH")]
        [HttpGet]
        public IActionResult XoaLSDH(int madon)
        {

            TempData["Message"] = "";



            db.Remove(db.Donhangs.Find(madon));

            db.SaveChanges();

            TempData["Message"] = "TK đã được xóa"; return RedirectToAction("LichSuDonHang", "HomeAdmin");


        }


        //Hoan Thanh Don Hang
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("HoanThanhDonHang")]

        public async Task<IActionResult> HoanThanhDonHang(int madon, int masp)
        {
            Chitietdonhang chitietdonhang = await db.Chitietdonhangs
                .SingleOrDefaultAsync(cd => cd.Madon == madon && cd.Masp == masp);

            if (chitietdonhang == null)
            {
                return NotFound();
            }

            return View(chitietdonhang);
        }


        //Loi Don Hang
        [Authentication]
        [Authentication_Ad]

        [HttpGet]
        [Route("LoiDonHang")]

        public async Task<IActionResult> LoiDonHang(int madon, int masp)
        {
            Chitietdonhang chitietdonhang = await db.Chitietdonhangs
                .SingleOrDefaultAsync(cd => cd.Madon == madon && cd.Masp == masp);

            if (chitietdonhang == null)
            {
                return NotFound();
            }

            return View(chitietdonhang);
        }



        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeAdminController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost]
        public async Task<IActionResult> UploadImage(IFormFile imageFile)
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                // Lưu ảnh vào thư mục wwwroot/images
                var filePath = Path.Combine(_webHostEnvironment.WebRootPath, "images", imageFile.FileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageFile.CopyToAsync(stream);
                }
                // Redirect về trang chủ
                return RedirectToAction("Index");
            }
            // Trả về view nếu upload thất bại
            return View();
        }


    }
}
