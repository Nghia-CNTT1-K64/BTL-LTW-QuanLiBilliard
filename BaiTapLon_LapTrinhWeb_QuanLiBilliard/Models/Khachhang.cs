using System;
using System.Collections.Generic;

namespace BaiTapLon_LapTrinhWeb_QuanLiBilliard.Models;

public partial class Khachhang
{
    public string Idkh { get; set; } = null!;

    public string? Hoten { get; set; }

    public string? Dchi { get; set; }

    public string? Sodt { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
