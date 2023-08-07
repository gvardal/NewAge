using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Uykonum
{
    public int KonumId { get; set; }

    public byte? FirmaId { get; set; }

    public string? KonumKodu { get; set; }

    public string Ad { get; set; } = null!;

    public byte? KonumTuruId { get; set; }

    public int? MasrafMerkezi { get; set; }

    public decimal? MaliyetOrani { get; set; }

    public decimal? DogalgazMaliyeti { get; set; }

    public decimal? ElektrikMaliyeti { get; set; }

    public decimal? SuMaliyeti { get; set; }

    public decimal? Kapasite { get; set; }

    public decimal? VardiyaUzunlugu { get; set; }

    public byte? KisaMolalar { get; set; }

    public decimal? KisaMolaSuresi { get; set; }

    public byte? YemekMolasi { get; set; }

    public decimal? YemekMolaSuresi { get; set; }

    public decimal? IdealUretimHizi { get; set; }

    public byte? CalismaGrubu { get; set; }

    public byte? ParalelIslemSayisi { get; set; }

    public double? FireOrani { get; set; }

    public decimal? FazlaUretimToleransi { get; set; }

    public int? HammaddeTuketimKonumId { get; set; }

    public int? HammaddeTuketimBolmesiId { get; set; }

    public int? StokKonumu { get; set; }

    public int? YariMamulStokKonumuId { get; set; }

    public short? VarsayilanOnKontrolSoruGrubuId { get; set; }

    public short? VarsayilanAraKontrolSoruGrubuId { get; set; }

    public int? UstKonumId { get; set; }

    public string? KonumKoduAdi { get; set; }

    public string? Aciklama { get; set; }

    public string? RaporAdi { get; set; }

    public bool? EksiyeDusebilir { get; set; }

    public string? Ipadres { get; set; }

    public string? SiraAraligi { get; set; }

    public string? RafAraligi { get; set; }

    public string? BolmeAraligi { get; set; }

    public int? Xkoordinati { get; set; }

    public int? Ykoordinati { get; set; }

    public bool? StokHareketleriniSirala { get; set; }

    public bool? Secili { get; set; }

    /// <summary>
    /// True ise Son Rota olması durumunda otomatik olarak Envanter oluştrma işlemini İPTAL eder.
    /// </summary>
    public bool? OtomatikEnvanterOlusturma { get; set; }

    public byte? DemirbasDurumu { get; set; }

    public bool? Aktif { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public string? SenkronizasyonKodu { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public virtual ICollection<BydegisenParcaListesi> BydegisenParcaListesis { get; set; } = new List<BydegisenParcaListesi>();

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();

    public virtual IkpdkscalismaGrubu? CalismaGrubuNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fdemirba> Fdemirbas { get; set; } = new List<Fdemirba>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayiKonums { get; set; } = new List<FyfaturaDetayi>();

    public virtual ICollection<FyfaturaDetayi> FyfaturaDetayiTeslimEdilecekKonums { get; set; } = new List<FyfaturaDetayi>();

    public virtual UykonumBolmeleri? HammaddeTuketimBolmesi { get; set; }

    public virtual Uykonum? HammaddeTuketimKonum { get; set; }

    public virtual ICollection<IitoplantiTutanagi> IitoplantiTutanagis { get; set; } = new List<IitoplantiTutanagi>();

    public virtual ICollection<IkpdkscalisanVardiyaPlani> IkpdkscalisanVardiyaPlanis { get; set; } = new List<IkpdkscalisanVardiyaPlani>();

    public virtual ICollection<Uykonum> InverseHammaddeTuketimKonum { get; set; } = new List<Uykonum>();

    public virtual ICollection<Uykonum> InverseStokKonumuNavigation { get; set; } = new List<Uykonum>();

    public virtual ICollection<Uykonum> InverseUstKonum { get; set; } = new List<Uykonum>();

    public virtual ICollection<Uykonum> InverseYariMamulStokKonumu { get; set; } = new List<Uykonum>();

    public virtual UykonumTuru? KonumTuru { get; set; }

    public virtual ICollection<KycatikToplamaDetayi> KycatikToplamaDetayis { get; set; } = new List<KycatikToplamaDetayi>();

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual PFymasrafMerkezi? MasrafMerkeziNavigation { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();

    public virtual ICollection<PFykonumMaliyetYerleri> PFykonumMaliyetYerleris { get; set; } = new List<PFykonumMaliyetYerleri>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPcesitliSarfMalzemeDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPdemirbasDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPfasonDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPfireDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPilkMaddeMalzemeDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPithalatDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPmamulStokAmbariNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPredDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<PfirmaBilgisi> PfirmaBilgisiPyariMamulDeposuNavigations { get; set; } = new List<PfirmaBilgisi>();

    public virtual ICollection<RyacilDurumKaydi> RyacilDurumKaydis { get; set; } = new List<RyacilDurumKaydi>();

    public virtual ICollection<SateklifSiparisTeslimatHareketi> SateklifSiparisTeslimatHareketis { get; set; } = new List<SateklifSiparisTeslimatHareketi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Uykonum? StokKonumuNavigation { get; set; }

    public virtual ICollection<SysiparisDetayi> SysiparisDetayis { get; set; } = new List<SysiparisDetayi>();

    public virtual ICollection<SyteslimatPlani> SyteslimatPlanis { get; set; } = new List<SyteslimatPlani>();

    public virtual Uykonum? UstKonum { get; set; }

    public virtual ICollection<UycalisanIslemTuru> UycalisanIslemTurus { get; set; } = new List<UycalisanIslemTuru>();

    public virtual ICollection<UyisAkisSoruGruplari> UyisAkisSoruGruplaris { get; set; } = new List<UyisAkisSoruGruplari>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsivis { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasis { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UykonumBolmeleri> UykonumBolmeleris { get; set; } = new List<UykonumBolmeleri>();

    public virtual ICollection<UykonumIslemTuru> UykonumIslemTurus { get; set; } = new List<UykonumIslemTuru>();

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayis { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UymalzemeIstekFisi> UymalzemeIstekFisis { get; set; } = new List<UymalzemeIstekFisi>();

    public virtual ICollection<UysarfMalzemeZimmet> UysarfMalzemeZimmetTeslimAlinanKonums { get; set; } = new List<UysarfMalzemeZimmet>();

    public virtual ICollection<UysarfMalzemeZimmet> UysarfMalzemeZimmetTeslimEdilenKonums { get; set; } = new List<UysarfMalzemeZimmet>();

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();

    public virtual ICollection<UytoplamEkipmanEtkinligi> UytoplamEkipmanEtkinligis { get; set; } = new List<UytoplamEkipmanEtkinligi>();

    public virtual ICollection<UyuretimPlani> UyuretimPlanis { get; set; } = new List<UyuretimPlani>();

    public virtual ICollection<UyurunAgaciHavuzu> UyurunAgaciHavuzuTeslimAlinacakKonumNavigations { get; set; } = new List<UyurunAgaciHavuzu>();

    public virtual ICollection<UyurunAgaciHavuzu> UyurunAgaciHavuzuTeslimEdilecekKonumNavigations { get; set; } = new List<UyurunAgaciHavuzu>();

    public virtual ICollection<UyurunAgaciPlanlama> UyurunAgaciPlanlamas { get; set; } = new List<UyurunAgaciPlanlama>();

    public virtual ICollection<UyurunAgaci> UyurunAgaciTeslimAlinacakKonumNavigations { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunAgaci> UyurunAgaciTeslimEdilecekKonumNavigations { get; set; } = new List<UyurunAgaci>();

    public virtual ICollection<UyurunKonumlari> UyurunKonumlaris { get; set; } = new List<UyurunKonumlari>();

    public virtual ICollection<UyurunRezervasyonu> UyurunRezervasyonus { get; set; } = new List<UyurunRezervasyonu>();

    public virtual ICollection<UyurunRotasi> UyurunRotasis { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunStogu> UyurunStogus { get; set; } = new List<UyurunStogu>();

    public virtual ICollection<Uyurunler> Uyurunlers { get; set; } = new List<Uyurunler>();

    public virtual UyisAkisSoruGruplari? VarsayilanAraKontrolSoruGrubu { get; set; }

    public virtual Uykonum? YariMamulStokKonumu { get; set; }

    public virtual ICollection<YmmusteriEnvanterArsivi> YmmusteriEnvanterArsivis { get; set; } = new List<YmmusteriEnvanterArsivi>();

    public virtual ICollection<YmmusteriEnvanter> YmmusteriEnvanters { get; set; } = new List<YmmusteriEnvanter>();
}
