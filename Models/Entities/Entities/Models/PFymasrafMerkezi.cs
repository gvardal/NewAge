using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PFymasrafMerkezi
{
    public int MasrafMerkeziId { get; set; }

    public string? MasrafMerkeziKodu { get; set; }

    public string? MasrafMerkeziAdi { get; set; }

    public bool? Aktif { get; set; }

    public string? OzelKod { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayis { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual ICollection<FymasrafMerkeziDagitimPlani> FymasrafMerkeziDagitimPlanis { get; set; } = new List<FymasrafMerkeziDagitimPlani>();

    public virtual ICollection<FyyevmiyeDefteriDetayiMasrafMerkezleri> FyyevmiyeDefteriDetayiMasrafMerkezleris { get; set; } = new List<FyyevmiyeDefteriDetayiMasrafMerkezleri>();

    public virtual ICollection<FyyevmiyeDefteriDetayi> FyyevmiyeDefteriDetayis { get; set; } = new List<FyyevmiyeDefteriDetayi>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PFymaliyetYerleri> PFymaliyetYerleris { get; set; } = new List<PFymaliyetYerleri>();

    public virtual ICollection<PsiparisTuru> PsiparisTurus { get; set; } = new List<PsiparisTuru>();

    public virtual ICollection<Pyprojeler> Pyprojelers { get; set; } = new List<Pyprojeler>();

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayis { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<Uykonum> Uykonums { get; set; } = new List<Uykonum>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayis { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UyurunKategorisi> UyurunKategorisis { get; set; } = new List<UyurunKategorisi>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
