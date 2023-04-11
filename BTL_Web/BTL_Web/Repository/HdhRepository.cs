using BTL_Web.Models;

namespace BTL_Web.Repository
{
	public interface HdhRepository
	{
        Hedieuhanh Add(Hedieuhanh loaiSp);
        Hedieuhanh Update(Hedieuhanh loaiSp);

        //THangSx Delete(THangSx maloaiSp);

        Hedieuhanh GetLoaiSp(int maloaiSp);

        IEnumerable<Hedieuhanh> GetAllLoaiSp();
    }
}
