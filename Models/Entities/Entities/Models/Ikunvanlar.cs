using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikunvanlar
{
    public short Id { get; set; }

    public byte? FirmaId { get; set; }

    public short? Birimi { get; set; }

    public short? BagliOlduguUnvan { get; set; }

    public string? UnvanKodu { get; set; }

    public string UnvanAdi { get; set; } = null!;

    public string UnvanKoduAdi { get; set; } = null!;

    public string? Aciklama { get; set; }

    public string? EkAtamaGorev { get; set; }

    public short? MeslekGrubuId { get; set; }

    public string? GorevinAnaAmaci { get; set; }

    public string? YeterlilikOgrenimDurumu { get; set; }

    public string? YeterlilikIsDeneyimi { get; set; }

    public string? YeterlilikProfil { get; set; }

    public string? YeterlilikBilgisayar { get; set; }

    public string? YeterlilikYabanciDil { get; set; }

    public byte? DikkatTestiDogru { get; set; }

    public byte? DikkatTestiYanlis { get; set; }

    public byte? DikkatTestiBos { get; set; }

    public string? DikkatTestiSure { get; set; }

    public byte? Pm38ogrendikleriniKullanabilme { get; set; }

    public byte? Pm38yenilikleeAcikOlma { get; set; }

    public byte? Pm38egitimMeslekiAltYapi { get; set; }

    public byte? Pm38deneyiminIseAktarilmasi { get; set; }

    public byte? Pm38toplam { get; set; }

    public string? KisilikTestiItercih { get; set; }

    public string? KisilikTestiIitercih { get; set; }

    public string? KisilikTestiIiitercih { get; set; }

    public short? IzkariyerGelisimi { get; set; }

    public short? Izliderlik { get; set; }

    public short? Izgirisimcilik { get; set; }

    public short? KisiselYeterlilikSkoru { get; set; }

    public short? MeslekiYeterlilikSkoru { get; set; }

    public short? ReferansSkoru { get; set; }

    public string? Iliskiler { get; set; }

    public string? GorevSorumlulukYetkiler { get; set; }

    public string? TozluOrtam { get; set; }

    public string? Gurultu { get; set; }

    public string? SicakOrtam { get; set; }

    public string? Titresim { get; set; }

    public string? YuksekCalisma { get; set; }

    public string? Kimyasal { get; set; }

    public string? NonIyonikRadyasyon { get; set; }

    public string? IyonikRadyasyon { get; set; }

    public string? Diger { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikunvanlar? BagliOlduguUnvanNavigation { get; set; }

    public virtual Ikorganizasyonlar? BirimiNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<DybyevrakBirimUnvanDagitimi> DybyevrakBirimUnvanDagitimis { get; set; } = new List<DybyevrakBirimUnvanDagitimi>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlars { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarUnvaniNavigations { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikcalisanlar> IkcalisanlarVekaletiNavigations { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<IkegitimIhtiyaclari> IkegitimIhtiyaclaris { get; set; } = new List<IkegitimIhtiyaclari>();

    public virtual ICollection<IkunvanRaporlari> IkunvanRaporlaris { get; set; } = new List<IkunvanRaporlari>();

    public virtual ICollection<IkunvanSorumluluklari> IkunvanSorumluluklaris { get; set; } = new List<IkunvanSorumluluklari>();

    public virtual ICollection<IkunvanYetkileri> IkunvanYetkileris { get; set; } = new List<IkunvanYetkileri>();

    public virtual ICollection<IkunvanYetkinlikleri> IkunvanYetkinlikleris { get; set; } = new List<IkunvanYetkinlikleri>();

    public virtual ICollection<IkunvanZimmet> IkunvanZimmets { get; set; } = new List<IkunvanZimmet>();

    public virtual ICollection<Ikunvanlar> InverseBagliOlduguUnvanNavigation { get; set; } = new List<Ikunvanlar>();

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();

    public virtual PIkmeslekGruplari? MeslekGrubu { get; set; }

    public virtual ICollection<RykisiselKoruyucuDonanimlar> RykisiselKoruyucuDonanimlars { get; set; } = new List<RykisiselKoruyucuDonanimlar>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<IihaberBandi> HaberBandis { get; set; } = new List<IihaberBandi>();
}
