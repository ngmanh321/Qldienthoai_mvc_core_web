using System;
using System.Collections.Generic;

namespace BTL_Web.Models;

public partial class Donhang
{
    public int Madon { get; set; }

    public DateTime? Ngaydat { get; set; }

    public string? TenTk { get; set; }

    public int Masp { get; set; }

    public int? Soluong { get; set; }

    public decimal? Dongia { get; set; }

    public string? Tenkhach { get; set; }

    public string? Diachi { get; set; }

    public string? Sdt { get; set; }

    public string? Trangthai { get; set; }

    public string? Tensp { get; set; }

    public virtual ICollection<Chitietdonhang> Chitietdonhangs { get; } = new List<Chitietdonhang>();

    public virtual Nguoidung? TenTkNavigation { get; set; }
}
