using BTL_Web.Models;

namespace BTL_Web.Repository
{
    public interface ManHinhRepository
    {
        Manhinh Add(Manhinh loaiSp);
        Manhinh Update(Manhinh loaiSp);

        //THangSx Delete(THangSx maloaiSp);

        Manhinh GetLoaiSp(int maloaiSp);

        IEnumerable<Manhinh> GetAllLoaiSp();
    }
}
