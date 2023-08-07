using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFytevkifatTurleri
{
    public string TevkifatTuruId { get; set; } = null!;

    public string? Aciklama { get; set; }

    public string KoduAciklamasi { get; set; } = null!;

    public byte? AliciOrani { get; set; }

    public byte? SaticiOrani { get; set; }

    public bool? Aktif { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
