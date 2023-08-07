using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunAgaciAktarma
{
    public int UrunAgaciId { get; set; }

    public int? AnaUrunId { get; set; }

    public int? UrunId { get; set; }

    public string? AnaKategori { get; set; }

    public string? AnaUrunKodu { get; set; }

    public string? AnaUrunUpc { get; set; }

    public string? AnaUrunAciklamasi { get; set; }

    public string? Kategori { get; set; }

    public string? MalzemeIsimleri { get; set; }

    public string? AnaUrun { get; set; }

    public string? MalzemeKoduI { get; set; }

    public string? MalzemeAdiI { get; set; }

    public string? MalzemeKoduIi { get; set; }

    public string? MalzemeAdiIi { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birim { get; set; }

    public string? BirimAciklamasi { get; set; }

    public decimal? IlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? ToplamIscilikSuresi { get; set; }

    public decimal? DirekIscilikMaliyeti { get; set; }

    public decimal? EkipmanKullanimMaliyeti { get; set; }

    public decimal? FasonIslemMaliyeti { get; set; }

    public decimal? GenelUretimMaliyeti { get; set; }

    public decimal? StandartMaliyet { get; set; }

    public decimal? FiiliIlkMaddeMalzemeMaliyeti { get; set; }

    public decimal? FiiliDirekIscilikMaliyeti { get; set; }

    public decimal? FiiliEkipmanKullanimMaliyeti { get; set; }

    public decimal? FiiliFasonIslemMaliyeti { get; set; }

    public decimal? FiiliGenelUretimMaliyeti { get; set; }

    public decimal? FiiliMaliyet { get; set; }

    public decimal? ToplamSatinAlmaMiktari { get; set; }

    public decimal? OrtalamaBirimSatinAlmaFiyati { get; set; }

    public decimal? ToplamSatinAlmaTutar { get; set; }

    public decimal? OrtalamaBirimSatisFiyati { get; set; }

    public decimal? ToplamSatisMiktari { get; set; }

    public decimal? ToplamSatisTutar { get; set; }

    public string? BaglantiTuru { get; set; }

    public byte? Islem1 { get; set; }

    public byte? Islem2 { get; set; }

    public byte? Islem3 { get; set; }

    public byte? Islem4 { get; set; }

    public byte? Islem5 { get; set; }

    public byte? Islem6 { get; set; }

    public byte? Islem7 { get; set; }

    public byte? Islem8 { get; set; }

    public byte? Islem9 { get; set; }

    public byte? Islem10 { get; set; }

    public byte? Islem11 { get; set; }

    public byte? Islem12 { get; set; }

    public byte? Islem13 { get; set; }

    public byte? Islem14 { get; set; }

    public byte? Islem15 { get; set; }

    public byte? Islem16 { get; set; }

    public byte? Islem17 { get; set; }

    public byte? Islem18 { get; set; }

    public byte? Islem19 { get; set; }

    public byte? Islem20 { get; set; }

    public byte? Islem21 { get; set; }

    public byte? Islem22 { get; set; }

    public byte? Islem23 { get; set; }

    public byte? Islem24 { get; set; }

    public byte? Islem25 { get; set; }

    public byte? Islem26 { get; set; }

    public byte? Islem27 { get; set; }

    public byte? Islem28 { get; set; }

    public byte? Islem29 { get; set; }

    public byte? Islem30 { get; set; }

    public byte? Islem31 { get; set; }

    public byte? Islem32 { get; set; }

    public byte? Islem33 { get; set; }

    public byte? Islem34 { get; set; }

    public byte? Islem35 { get; set; }

    public byte? Islem36 { get; set; }

    public byte? Islem37 { get; set; }

    public byte? Islem38 { get; set; }

    public byte? Islem39 { get; set; }

    public byte? Islem40 { get; set; }

    public virtual Uyurunler? AnaUrunNavigation { get; set; }

    public virtual Uyurunler? Urun { get; set; }
}
