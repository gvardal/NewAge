using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class IkyasalUyumTablosu
{
    public int YasalUyumId { get; set; }

    public DateTime? ResmiGazeteYayinTarihi { get; set; }

    public string? YayinNo { get; set; }

    public string? IlgiliYonetmelik { get; set; }

    public string? IlgiliTaraf { get; set; }

    public string? Konu { get; set; }

    public string? Madde { get; set; }

    public string? Hukum { get; set; }

    public DateTime? YururlulukTarihi { get; set; }

    public string? Periyod { get; set; }

    public string? MevcutDurum { get; set; }

    public bool? UygunlukDurumu { get; set; }

    public string? GerekliAksiyon { get; set; }

    public string? Sorumlu { get; set; }

    public bool? DofistegiAc { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
