using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BTL_Web.Models;

public partial class Chitietdonhang
{
    public int Madon { get; set; }

    public int Masp { get; set; }

    public int? Soluong { get; set; }

    public decimal? Dongia { get; set; }

    [Required(ErrorMessage = "Tên khách hàng không được để trống")]
    [RegularExpression(@"^.{3,}$", ErrorMessage = "Tên khách hàng lớn hơn 2 kí tự")]
    public string? Tenkhach { get; set; }

    [Required(ErrorMessage = "Dia chi hàng không được để trống")]
    [RegularExpression(@"^.{6,}$", ErrorMessage = "Diachi phải có độ dài lớn hơn 5 kí tự")]
    public string? Diachi { get; set; }

    [Required(ErrorMessage = "SDT hàng không được để trống")]
    [RegularExpression(@"^.{6,}$", ErrorMessage = "Sdt phải có độ dài lớn hơn 5 kí tự")]
    public string? Sdt { get; set; }

    public string? TenTK { get; set; }

    public string? Tensp { get; set; }



}
