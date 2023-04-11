using BTL_Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BTL_Web.ViewComponents
{
    public class HangSxViewComponent : ViewComponent
    {
        private readonly HangSxRepository _loaiSp;
        public HangSxViewComponent(HangSxRepository loaisp)
        {
            _loaiSp = loaisp;

        }

        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Tenhang);
            return View(loaisp);
        }
    }
}
