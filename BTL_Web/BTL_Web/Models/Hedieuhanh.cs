using System;
using System.Collections.Generic;

namespace BTL_Web.Models;

public partial class Hedieuhanh
{
    public int Mahdh { get; set; }

    public string? Tenhdh { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; } = new List<Sanpham>();
}
