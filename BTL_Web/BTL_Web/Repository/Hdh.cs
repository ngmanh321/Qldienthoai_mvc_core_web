using BTL_Web.Models;

namespace BTL_Web.Repository
{
    public class Hdh : HdhRepository
    {
        private readonly QldienthoaiContext _context;


        public Hdh(QldienthoaiContext context)
        {
            _context = context;
        }

        public Hedieuhanh Add(Hedieuhanh loaiSp)
        {
            _context.Hedieuhanhs.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;

        }



        public IEnumerable<Hedieuhanh> GetAllLoaiSp()
        {
            return _context.Hedieuhanhs;
        }

        public Hedieuhanh GetLoaiSp(int maloaiSp)
        {
            return _context.Hedieuhanhs.Find(maloaiSp);
        }

        public Hedieuhanh Update(Hedieuhanh loaiSp)
        {
            _context.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
