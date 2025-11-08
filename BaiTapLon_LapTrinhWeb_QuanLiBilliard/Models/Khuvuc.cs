using System;
using System.Collections.Generic;

namespace BaiTapLon_LapTrinhWeb_QuanLiBilliard.Models;

public partial class Khuvuc
{
    public string Idkhu { get; set; } = null!;

    public string? Tenkhu { get; set; }

    public virtual ICollection<Ban> Bans { get; set; } = new List<Ban>();
}
