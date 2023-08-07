using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyurunKategorisi
{
    public int UrunKategorisiId { get; set; }

    public string? UrunAilesiId { get; set; }

    public int? UstKategorisiId { get; set; }

    public string? Kod { get; set; }

    public string? TamKod { get; set; }

    public string? UrunKategorisiKoduAdi { get; set; }

    public byte? KodlamaTuru { get; set; }

    public string? Ad { get; set; }

    public string? Aciklama { get; set; }

    public bool? StandartFiyatListesi { get; set; }

    public short? SonKullaniciKarOrani { get; set; }

    public short? BayiKarOrani { get; set; }

    public short? IsOrtagiKarOrani { get; set; }

    public short? ProjeKarOrani { get; set; }

    public short? ListeKarOrani { get; set; }

    public string? Resim { get; set; }

    public string? EnAd { get; set; }

    public short? SiraNo { get; set; }

    public string? Gtipkodu { get; set; }

    public byte? HesaplamaTuru { get; set; }

    public int? SablonProjeId { get; set; }

    public short? UrunGrubuId { get; set; }

    public int? BdyurticiSatisHesabiId { get; set; }

    public int? BdyurtdisiSatisHesabiId { get; set; }

    public int? BdyisatisIadeMuhasebeHesapId { get; set; }

    public int? BdstokMuhasebeHesabiId { get; set; }

    public int? BdmaliyetMuhasebeHesapId { get; set; }

    public int? BdarGeMuhasebeHesapId { get; set; }

    public int? BdmasrafMerkeziId { get; set; }

    public bool? SenkronizasyonGrubu { get; set; }

    public string? SenkronizasyonGrupKodu { get; set; }

    public string? SenkronizasyonGrupAdi { get; set; }

    public bool? B2b { get; set; }

    public bool? B2c { get; set; }

    public byte[]? ResimImg { get; set; }

    public string? OzelKodu { get; set; }

    public string? Uyspazar { get; set; }

    public string? Uyssegment { get; set; }

    public string? Uysmarka { get; set; }

    public string? UysrafOmru { get; set; }

    public string? UysuretimIzni { get; set; }

    public string? Uysts { get; set; }

    public string? UysurunTipi { get; set; }

    public string? UysurunCesidi { get; set; }

    public string? Uysicındekiler { get; set; }

    public string? UysicındekilerAlerjenUyarisi { get; set; }

    public string? UysuretimHattiAlerjenUyarisi { get; set; }

    public virtual FyhesapPlani? BdarGeMuhasebeHesap { get; set; }

    public virtual FyhesapPlani? BdmaliyetMuhasebeHesap { get; set; }

    public virtual PFymasrafMerkezi? BdmasrafMerkezi { get; set; }

    public virtual FyhesapPlani? BdstokMuhasebeHesabi { get; set; }

    public virtual FyhesapPlani? BdyisatisIadeMuhasebeHesap { get; set; }

    public virtual FyhesapPlani? BdyurtdisiSatisHesabi { get; set; }

    public virtual FyhesapPlani? BdyurticiSatisHesabi { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual ICollection<UyurunKategorisi> InverseUstKategorisi { get; set; } = new List<UyurunKategorisi>();

    public virtual PUykodlamaTuru? KodlamaTuruNavigation { get; set; }

    public virtual ICollection<MiysahesapKategoriIskontolari> MiysahesapKategoriIskontolaris { get; set; } = new List<MiysahesapKategoriIskontolari>();

    public virtual PyprojeHavuzu? SablonProje { get; set; }

    public virtual ICollection<SasatinAlmaTalebiDetayi> SasatinAlmaTalebiDetayis { get; set; } = new List<SasatinAlmaTalebiDetayi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual ICollection<SateklifSiparisDetayi> SateklifSiparisDetayis { get; set; } = new List<SateklifSiparisDetayi>();

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<SyurunKategorisiAciklamalari> SyurunKategorisiAciklamalaris { get; set; } = new List<SyurunKategorisiAciklamalari>();

    public virtual UyurunAilesi? UrunAilesi { get; set; }

    public virtual PUyurunGruplari? UrunGrubu { get; set; }

    public virtual UyurunKategorisi? UstKategorisi { get; set; }

    public virtual ICollection<UykategoriOzellikleri> UykategoriOzellikleris { get; set; } = new List<UykategoriOzellikleri>();

    public virtual ICollection<UymalzemeIhtiyacPlani> UymalzemeIhtiyacPlanis { get; set; } = new List<UymalzemeIhtiyacPlani>();

    public virtual ICollection<UysambalajBilgisi> UysambalajBilgisis { get; set; } = new List<UysambalajBilgisi>();

    public virtual ICollection<UysambalajMalzemeleri> UysambalajMalzemeleris { get; set; } = new List<UysambalajMalzemeleri>();

    public virtual ICollection<UyurunAgaci> UyurunAgacis { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();
}
