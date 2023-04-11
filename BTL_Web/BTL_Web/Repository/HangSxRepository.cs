using BTL_Web.Models;

namespace BTL_Web.Repository
{
	public interface HangSxRepository
	{
        Hangsanxuat Add(Hangsanxuat loaiSp);
        Hangsanxuat Update(Hangsanxuat loaiSp);

        //THangSx Delete(THangSx maloaiSp);

        Hangsanxuat GetLoaiSp(int maloaiSp);

        IEnumerable<Hangsanxuat> GetAllLoaiSp();
    }
}
