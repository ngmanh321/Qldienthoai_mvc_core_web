using BTL_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web02_03.Models.ProductModels;

namespace BTL_Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class API2Controller : ControllerBase
    {
        QldienthoaiContext db = new QldienthoaiContext();

        [HttpGet]
        public IEnumerable<Chitietdonhang> GetAll()
        {
            var sanPham = (from p in db.Chitietdonhangs
                           select new Chitietdonhang
                           {   
                               Madon = p.Madon,
                               Masp = p.Masp,
                               Soluong = p.Soluong,
                               Dongia = p.Dongia,
                               Tenkhach = p.Tenkhach,
                               Diachi = p.Diachi,
                               Sdt = p.Sdt,
                               TenTK = p.TenTK,
                               Tensp = p.Tensp,


                           }).ToList();
            return sanPham;
        }

        // lay ra danh sach don hang theo tentk
        [HttpGet("{tentk}")]
        public IEnumerable<Chitietdonhang> GetTenTK(string tentk )
        {
            var sanPham = (from p in db.Chitietdonhangs
                           where p.TenTK == tentk 
                           select new Chitietdonhang
                           {
                               Madon = p.Madon,
                               Masp = p.Masp,
                               Soluong = p.Soluong,
                               Dongia = p.Dongia,
                               Tenkhach = p.Tenkhach,
                               Diachi = p.Diachi,
                               Sdt = p.Sdt,
                               Tensp = p.Tensp,
                           }).ToList();
            return sanPham;
        }



        // them vao don hang
        [HttpPost("")]
        public IActionResult ThemDonHang([FromBody] Chitietdonhang sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Chitietdonhangs.Add(sanPham);
                db.SaveChanges();
            }
            return Ok(sanPham);
        }


        [HttpDelete("{madon}/{masp}")]
        public async Task<IActionResult> DeleteTDanhMucSp(int madon, int masp)
        {

            var xoadon = await db.Chitietdonhangs.FindAsync(madon, masp);
            if (xoadon == null)
            {
                return NotFound();
            }
            db.Chitietdonhangs.Remove(xoadon);
            await db.SaveChangesAsync();
            return NoContent();
        }


    }
}
