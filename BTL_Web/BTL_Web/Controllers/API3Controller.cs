using BTL_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTL_Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class API3Controller : ControllerBase
	{
        QldienthoaiContext db = new QldienthoaiContext();

        // lay ra danh sach cua trang thai don hang theo tentk
        [HttpGet("{tentk}")]
        public IEnumerable<Donhang> GetTenTK(string tentk)
        {
            var sanPham = (from p in db.Donhangs
                           where p.TenTk == tentk
                           select new Donhang
                           {
                               Madon = p.Madon,
                               Masp = p.Masp,
                               Soluong = p.Soluong,
                               Dongia = p.Dongia,
                               Tenkhach = p.Tenkhach,
                               Diachi = p.Diachi,
                               Sdt = p.Sdt,
                               Tensp = p.Tensp,
                               Trangthai = p.Trangthai ,

                           }).ToList();
            return sanPham;
        }



        // them 1 tai khoan moi vao bang nguoidung
        [HttpPost("")]
        public IActionResult Signup([FromBody] Nguoidung sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Nguoidungs.Add(sanPham);
                db.SaveChanges();
            }
            return Ok(sanPham);
        }
    }
}
