using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunStogu
{
    public int UrunId { get; set; }

    public int KonumId { get; set; }

    public byte? FirmaId { get; set; }

    public string? Raf { get; set; }

    public string? Bolme { get; set; }

    public string? Sira { get; set; }

    public decimal Miktar { get; set; }

    public decimal? Iimiktar { get; set; }

    public decimal AyrilmisMiktar { get; set; }

    public decimal? KullanilabilirMiktar { get; set; }

    public decimal? YoldakiMiktar { get; set; }

    public DateTime? TahminiGelisTarihi { get; set; }

    public decimal? KaliteKontrolMiktar { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Uykonum Konum { get; set; } = null!;

    public virtual Uyurunler Urun { get; set; } = null!;

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<UyurunStokDetayi> UyurunStokDetayis { get; set; } = new List<UyurunStokDetayi>();
}
