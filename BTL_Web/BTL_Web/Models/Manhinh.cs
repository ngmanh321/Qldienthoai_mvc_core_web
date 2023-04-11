using System;
using System.Collections.Generic;

namespace BTL_Web.Models;

public partial class Manhinh
{
    public string Mamanhinh { get; set; } = null!;

    public string? Tenmanhinh { get; set; }

    public virtual ICollection<Sanpham> Sanphams { get; } = new List<Sanpham>();
}
