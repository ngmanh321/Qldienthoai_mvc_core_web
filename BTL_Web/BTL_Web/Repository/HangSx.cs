using BTL_Web.Models;

namespace BTL_Web.Repository
{
    public class HangSx : HangSxRepository
    {
        private readonly QldienthoaiContext _context;


        public HangSx(QldienthoaiContext context)
        {
            _context = context;
        }

        public Hangsanxuat Add(Hangsanxuat loaiSp)
        {
            _context.Hangsanxuats.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;

        }



        public IEnumerable<Hangsanxuat> GetAllLoaiSp()
        {
            return _context.Hangsanxuats;
        }

        public Hangsanxuat GetLoaiSp(int maloaiSp)
        {
            return _context.Hangsanxuats.Find(maloaiSp);
        }

        public Hangsanxuat Update(Hangsanxuat loaiSp)
        {
            _context.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }

    }
}
