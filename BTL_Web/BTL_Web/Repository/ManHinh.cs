using BTL_Web.Models;

namespace BTL_Web.Repository
{
    public class ManHinh : ManHinhRepository
    {
        private readonly QldienthoaiContext _context;


        public ManHinh(QldienthoaiContext context)
        {
            _context = context;
        }

        public Manhinh Add(Manhinh loaiSp)
        {
            _context.Manhinhs.Add(loaiSp);
            _context.SaveChanges();
            return loaiSp;

        }



        public IEnumerable<Manhinh> GetAllLoaiSp()
        {
            return _context.Manhinhs;
        }

        public Manhinh GetLoaiSp(int maloaiSp)
        {
            return _context.Manhinhs.Find(maloaiSp);
        }

        public Manhinh Update(Manhinh loaiSp)
        {
            _context.Update(loaiSp);
            _context.SaveChanges();
            return loaiSp;
        }
    }
}
