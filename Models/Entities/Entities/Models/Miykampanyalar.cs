using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Miykampanyalar
{
    public long Id { get; set; }

    public int? KampanyaSahibi { get; set; }

    public string? KampanyaAdi { get; set; }

    public string? Turu { get; set; }

    public string? Durumu { get; set; }

    public DateTime? BaslamaTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public decimal? BeklenenKazanc { get; set; }

    public decimal? ButcelenenHarcama { get; set; }

    public decimal? GerceklesenHarcama { get; set; }

    public int? BeklenenGeriDonus { get; set; }

    public bool? Aktif { get; set; }

    public string? Aciklama { get; set; }

    public string? Degerlendirme { get; set; }

    public int? IsOrtagi { get; set; }

    public int? MusteriId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miysahesaplar? IsOrtagiNavigation { get; set; }

    public virtual Ikcalisanlar? KampanyaSahibiNavigation { get; set; }

    public virtual ICollection<Miyfirsatlar> Miyfirsatlars { get; set; } = new List<Miyfirsatlar>();

    public virtual ICollection<MiykampanyaUrunler> MiykampanyaUrunlers { get; set; } = new List<MiykampanyaUrunler>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual Miysahesaplar? Musteri { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
