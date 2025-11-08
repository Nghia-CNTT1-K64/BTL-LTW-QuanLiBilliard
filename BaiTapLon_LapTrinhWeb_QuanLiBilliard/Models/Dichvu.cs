using System;
using System.Collections.Generic;

namespace BaiTapLon_LapTrinhWeb_QuanLiBilliard.Models;

public partial class Dichvu
{
    public string Iddv { get; set; } = null!;

    public string? Tendv { get; set; }

    public string? Loaidv { get; set; }

    public decimal? Giatien { get; set; }

    public int? Soluong { get; set; }

    public bool? Hienthi { get; set; }

    public virtual ICollection<Hoadondv> Hoadondvs { get; set; } = new List<Hoadondv>();
}
