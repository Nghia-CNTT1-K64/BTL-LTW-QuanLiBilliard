using System;
using System.Collections.Generic;

namespace BaiTapLon_LapTrinhWeb_QuanLiBilliard.Models;

public partial class Hoadondv
{
    public string Idhd { get; set; } = null!;

    public string Iddv { get; set; } = null!;

    public int? Soluong { get; set; }

    public virtual Dichvu IddvNavigation { get; set; } = null!;

    public virtual Hoadon IdhdNavigation { get; set; } = null!;
}
