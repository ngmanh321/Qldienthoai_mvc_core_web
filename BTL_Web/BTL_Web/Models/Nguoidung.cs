using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTL_Web.Models;

public partial class Nguoidung
{
    [Required(ErrorMessage = "Tên TK không được để trống")]
    [RegularExpression(@"^.{3,}$", ErrorMessage = "TenTK phải có độ dài lớn hơn 2 kí tự")]
    public string TenTk { get; set; } = null!;

    [Required(ErrorMessage = "MK không được để trống")]
    [RegularExpression(@"^.{3,}$", ErrorMessage = "MK phải có độ dài lớn hơn 2 kí tự")]
    public string? MatKhau { get; set; }

    public string? LoaiTk { get; set; }

    public virtual ICollection<Donhang> Donhangs { get; } = new List<Donhang>();
}
