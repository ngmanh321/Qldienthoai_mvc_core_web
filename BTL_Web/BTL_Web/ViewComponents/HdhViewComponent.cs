using BTL_Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BTL_Web.ViewComponents
{
    public class HdhViewComponent : ViewComponent
    {
        private readonly HdhRepository _loaiSp;
        public HdhViewComponent(HdhRepository loaisp)
        {
            _loaiSp = loaisp;

        }

        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Tenhdh);
            return View(loaisp);
        }
    }
}
