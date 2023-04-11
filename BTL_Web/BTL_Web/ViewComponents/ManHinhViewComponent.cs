using BTL_Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BTL_Web.ViewComponents
{
    public class ManHinhViewComponent : ViewComponent
    {
        private readonly ManHinhRepository _loaiSp;
        public ManHinhViewComponent(ManHinhRepository loaisp)
        {
            _loaiSp = loaisp;

        }

        public IViewComponentResult Invoke()
        {
            var loaisp = _loaiSp.GetAllLoaiSp().OrderBy(x => x.Tenmanhinh);
            return View(loaisp);
        }
    }
}
