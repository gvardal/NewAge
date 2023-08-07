using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiypmgorusmeSonuclari
{
    public long Id { get; set; }

    public int? IlgiliGorev { get; set; }

    public int? FirsatId { get; set; }

    public int? MusteriId { get; set; }

    public DateTime? GorusmeTarihi { get; set; }

    public string? GorusmeTuru { get; set; }

    public int? KontakId { get; set; }

    public bool? Ozel { get; set; }

    public string? Konu { get; set; }

    public string? GorusmeSonucu { get; set; }

    public double? Enlem { get; set; }

    public double? Boylam { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Miyfirsatlar? Firsat { get; set; }

    public virtual Ggorevler? IlgiliGorevNavigation { get; set; }

    public virtual Ikcalisanlar? Kontak { get; set; }

    public virtual Miysahesaplar? Musteri { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
