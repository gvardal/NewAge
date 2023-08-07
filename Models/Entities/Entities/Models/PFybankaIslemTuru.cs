using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFybankaIslemTuru
{
    public byte BankaIslemTuruId { get; set; }

    public string? Aciklama { get; set; }

    public bool? GidenGelen { get; set; }

    public virtual ICollection<FybankaHesapHareketi> FybankaHesapHareketis { get; set; } = new List<FybankaHesapHareketi>();
}
