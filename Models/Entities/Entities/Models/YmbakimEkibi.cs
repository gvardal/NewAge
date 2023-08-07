using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class YmbakimEkibi
{
    public int BakimEkibiId { get; set; }

    public int? TerminalNo { get; set; }

    public DateTime? SonGuncellemeTarihi { get; set; }

    public short? AracId { get; set; }

    public string? Ad { get; set; }

    public bool? IcBakim { get; set; }

    public string? AracPlakaBilgisi { get; set; }

    public string? DorsePlakaBilgisi { get; set; }

    public virtual Lyaraclar? Arac { get; set; }

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual Fdemirba? TerminalNoNavigation { get; set; }

    public virtual ICollection<YmmusteriBakimPlani> YmmusteriBakimPlanis { get; set; } = new List<YmmusteriBakimPlani>();
}
