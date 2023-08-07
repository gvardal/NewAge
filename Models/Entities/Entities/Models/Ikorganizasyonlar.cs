using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Ikorganizasyonlar
{
    public short Id { get; set; }

    public byte? FirmaId { get; set; }

    public short? BagliOlduguBirim { get; set; }

    public string? BirimKodu { get; set; }

    public string BirimAdi { get; set; } = null!;

    public string BirimKoduAdi { get; set; } = null!;

    public int? DepartmanSorumlusu { get; set; }

    public string? BirimAciklamasi { get; set; }

    public string? VarsayilanMaliyetHesabiKodu { get; set; }

    public int? MasrafMerkeziId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikorganizasyonlar? BagliOlduguBirimNavigation { get; set; }

    public virtual Ikcalisanlar? DepartmanSorumlusuNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual ICollection<DybyevrakBirimUnvanDagitimi> DybyevrakBirimUnvanDagitimis { get; set; } = new List<DybyevrakBirimUnvanDagitimi>();

    public virtual ICollection<DydisKaynakliDokuman> DydisKaynakliDokumen { get; set; } = new List<DydisKaynakliDokuman>();

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<IkacikPozisyonlar> IkacikPozisyonlars { get; set; } = new List<IkacikPozisyonlar>();

    public virtual ICollection<Ikcalisanlar> Ikcalisanlars { get; set; } = new List<Ikcalisanlar>();

    public virtual ICollection<Ikunvanlar> Ikunvanlars { get; set; } = new List<Ikunvanlar>();

    public virtual ICollection<Ikorganizasyonlar> InverseBagliOlduguBirimNavigation { get; set; } = new List<Ikorganizasyonlar>();

    public virtual ICollection<Kshedefler> Kshedeflers { get; set; } = new List<Kshedefler>();

    public virtual ICollection<KsstratejikAmaclar> KsstratejikAmaclars { get; set; } = new List<KsstratejikAmaclar>();

    public virtual ICollection<KyicTetkikPlani> KyicTetkikPlanis { get; set; } = new List<KyicTetkikPlani>();

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<KyriskYonetimi> KyriskYonetimis { get; set; } = new List<KyriskYonetimi>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();

    public virtual ICollection<RyacilDurumKaydi> RyacilDurumKaydis { get; set; } = new List<RyacilDurumKaydi>();

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual ICollection<YmmusteriIstekSikayetleri> YmmusteriIstekSikayetleris { get; set; } = new List<YmmusteriIstekSikayetleri>();

    public virtual ICollection<IihaberBandi> HaberBandis { get; set; } = new List<IihaberBandi>();
}
