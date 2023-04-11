using System;
using System.Collections.Generic;

namespace BTL_Web.Models;

public partial class Hangsanxuat
{
    public int Mahang { get; set; }

    public string? Tenhang { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; } = new List<Sanpham>();
}
