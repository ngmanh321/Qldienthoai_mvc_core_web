using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTL_Web.Models;

public partial class Sanpham
{
    public int Masp { get; set; }

    public string? Tensp { get; set; }

    public decimal? Giatien { get; set; }

    public int? Soluong { get; set; }

    public string? Mota { get; set; }

    public int? Thesim { get; set; }

    public int? Bonhotrong { get; set; }

    public int? Ram { get; set; }

    public string? Anhbia { get; set; }

    public int? Mahang { get; set; }

    public int? Mahdh { get; set; }

    public string? Camera { get; set; }

    public string? Pin { get; set; }

    public string? Chip { get; set; }

    public string? Mamanhinh { get; set; }

    public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; } = new List<Chitietdonhang>();

    public virtual Hangsanxuat? MahangNavigation { get; set; }

    public virtual Hedieuhanh? MahdhNavigation { get; set; }

    public virtual Manhinh? MamanhinhNavigation { get; set; }
}
