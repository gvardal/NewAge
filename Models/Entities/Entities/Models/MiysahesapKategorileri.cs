using System;
using System.Collections.Generic;

namespace Entities.Models;

/// <summary>
/// CariHesapları Gruplara ayırıp analiz etmek için kullanılır
/// </summary>
public partial class MiysahesapKategorileri
{
    public short KategoriId { get; set; }

    public string? KategoriKodu { get; set; }

    public string? KategoriAdi { get; set; }

    public string? KategoriAciklamasi { get; set; }

    public short? UstKategoriId { get; set; }

    public bool? SatisSatinAlma { get; set; }

    public int? EkleyenCalisan { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisan { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual ICollection<MiysahesapKategorileri> InverseUstKategori { get; set; } = new List<MiysahesapKategorileri>();

    public virtual ICollection<MiymusteriOzellikleri> MiymusteriOzellikleris { get; set; } = new List<MiymusteriOzellikleri>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual MiysahesapKategorileri? UstKategori { get; set; }
}
