using BTL_Web.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Policy;
using Web02_03.Models.ProductModels;

namespace BTL_Web.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class APIController : ControllerBase
	{

        QldienthoaiContext db = new QldienthoaiContext();

        [HttpGet]
        public IEnumerable<Product> GetAllProduct()
        {
            var sanPham = (from p in db.Sanphams
                           select new Product
                           {
                               Masp = p.Masp,
                               Tensp = p.Tensp,
                               Giatien = p.Giatien,
                               Anhbia = p.Anhbia,
                           }).ToList();
            return sanPham;
        }
        // tim kiem san pham
        [HttpGet("{masp}")]
        public IEnumerable<Product> GetProductByCategory(string masp)
        {
            var sanPham = (from p in db.Sanphams
                           where p.Tensp == masp
                           select new Product
                           {
                               Masp = p.Masp,
                               Tensp = p.Tensp,
                               Giatien = p.Giatien,
                               Anhbia = p.Anhbia,
                           }).ToList();
            return sanPham;
        }



        // them vao trang thai cua don hang
        [HttpPost("")]
        public IActionResult ThemTrangThaiDonHang([FromBody] Donhang sanPham)
        {
            if (ModelState.IsValid)
            {
                db.Donhangs.Add(sanPham);
                db.SaveChanges();
            }
            return Ok(sanPham);
        }



    }


}
