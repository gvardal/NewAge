using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KycatikToplamaDetayi
{
    public int AtikToplamaDetayiId { get; set; }

    public int? AtikToplamaId { get; set; }

    public int? AtikTuruId { get; set; }

    public int? KonumId { get; set; }

    public decimal? Miktar { get; set; }

    /// <summary>
    /// 1-Adet 2-cc 3-Düzine 4-Feet 5-Inches 6-Kilogram 7-Metre
    /// </summary>
    public int? OlcuBirimiId { get; set; }

    public string? Aciklama { get; set; }

    public int? IlgiliUrun { get; set; }

    public int? BertarafYontemiId { get; set; }

    public int? GeriDonusumYontemiId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual KycatikToplamaKayitlari? AtikToplama { get; set; }

    public virtual KycatikTanimlari? AtikTuru { get; set; }

    public virtual PKycbertarafYontemleri? BertarafYontemi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PKycgeriDonusumYontemleri? GeriDonusumYontemi { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual PolcuBirimleri? OlcuBirimi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
