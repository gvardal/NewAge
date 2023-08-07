using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Fdemirba
{
    public int DemirbasId { get; set; }

    public byte? FirmaId { get; set; }

    public int? BagliOlduguDemirbasId { get; set; }

    public string DemirbasKoduAdi { get; set; } = null!;

    public string? DemirbasKodu { get; set; }

    public string? BarkodNo { get; set; }

    public string? Rfidno { get; set; }

    public string? DemirbasAdi { get; set; }

    public string? SeriNo { get; set; }

    public byte[]? Resim { get; set; }

    public string? Islevi { get; set; }

    public DateTime? EdinmeTarihi { get; set; }

    public byte? DemirbasTuru { get; set; }

    public byte? DemirbasDurumu { get; set; }

    public int? MiysahesaplarId { get; set; }

    public int? DemirbasKategorisiId { get; set; }

    public int? UrunId { get; set; }

    public short? UrunMarkasiId { get; set; }

    public string? Aciklama { get; set; }

    public string? Aciklama2 { get; set; }

    public string? DosyaSaklamaYeri { get; set; }

    public byte? KalipGozSayisi { get; set; }

    public short? IlgiliDepartman { get; set; }

    public int? Konumu { get; set; }

    public short? IlgiliUnvan { get; set; }

    public int? Sorumlusu { get; set; }

    public string? Kapasitesi { get; set; }

    public string? GunlukCalismaSuresi { get; set; }

    public string? FireOrani { get; set; }

    public string? CalismaSaatleri { get; set; }

    public DateTime? SonKullanimTarihi { get; set; }

    public decimal? SatinAlmaDegeri { get; set; }

    public decimal? HurdaDegeri { get; set; }

    public short? DemirbasKullanimOmru { get; set; }

    public string? AmortismanDonemi { get; set; }

    public string? AmortismanYontemi { get; set; }

    public bool? AmortismanKisitli { get; set; }

    public double? AmortismanOrani { get; set; }

    public decimal? SigortaDegeri { get; set; }

    public DateTime? PlanlananHurdaTarihi { get; set; }

    public DateTime? GerceklesenHurdaTarihi { get; set; }

    public bool? GarantiKapsami { get; set; }

    public string? GarantiSuresi { get; set; }

    public DateTime? GarantiBaslangicTarihi { get; set; }

    public DateTime? GarantiBitisTarihi { get; set; }

    public decimal? GunlukKullanimBedeli { get; set; }

    public long? SateklifSiparisTeslimatHareketiId { get; set; }

    public int? AlternatifEkipmanId { get; set; }

    public int? MusteriId { get; set; }

    public bool? MulkiyetId { get; set; }

    public string? CihazHassasiyeti { get; set; }

    public string? OlcmeAraligi { get; set; }

    public short? KalibrasyonPeriyodu { get; set; }

    public int? KalibrasyonFirmasiId { get; set; }

    public short? IsAkisSoruGrubuId { get; set; }

    public int? FydemirbasGirisMuhasebeHesabiId { get; set; }

    public int? FygiderMuhasebeHesabiId { get; set; }

    public int? FybirikmisAmortismanMuhasebeHesabiId { get; set; }

    public int? FydemirbasCikisMuhasebeHesabiId { get; set; }

    public int? FymasrafMerkeziId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Fdemirba? AlternatifEkipman { get; set; }

    public virtual Fdemirba? BagliOlduguDemirbas { get; set; }

    public virtual ICollection<BymakinaCalisan> BymakinaCalisans { get; set; } = new List<BymakinaCalisan>();

    public virtual ICollection<ByyillikBakimPlani> ByyillikBakimPlanis { get; set; } = new List<ByyillikBakimPlani>();

    public virtual PFdemirbasDurumu? DemirbasDurumuNavigation { get; set; }

    public virtual UyurunKategorisi? DemirbasKategorisi { get; set; }

    public virtual PFdemirbasTuru? DemirbasTuruNavigation { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<FdemirbasAmortismanlari> FdemirbasAmortismanlaris { get; set; } = new List<FdemirbasAmortismanlari>();

    public virtual ICollection<FdemirbasZimmet> FdemirbasZimmets { get; set; } = new List<FdemirbasZimmet>();

    public virtual PfirmaBilgisi? Firma { get; set; }

    public virtual FyhesapPlani? FybirikmisAmortismanMuhasebeHesabi { get; set; }

    public virtual FyhesapPlani? FydemirbasCikisMuhasebeHesabi { get; set; }

    public virtual FyhesapPlani? FydemirbasGirisMuhasebeHesabi { get; set; }

    public virtual FyhesapPlani? FygiderMuhasebeHesabi { get; set; }

    public virtual PFymasrafMerkezi? FymasrafMerkezi { get; set; }

    public virtual Ikorganizasyonlar? IlgiliDepartmanNavigation { get; set; }

    public virtual Ikunvanlar? IlgiliUnvanNavigation { get; set; }

    public virtual ICollection<Fdemirba> InverseAlternatifEkipman { get; set; } = new List<Fdemirba>();

    public virtual ICollection<Fdemirba> InverseBagliOlduguDemirbas { get; set; } = new List<Fdemirba>();

    public virtual UyisAkisSoruGruplari? IsAkisSoruGrubu { get; set; }

    public virtual Miysahesaplar? KalibrasyonFirmasi { get; set; }

    public virtual Uykonum? KonumuNavigation { get; set; }

    public virtual ICollection<KyisKazalari> KyisKazalaris { get; set; } = new List<KyisKazalari>();

    public virtual ICollection<KykalibrasyonPlani> KykalibrasyonPlaniDemirbas { get; set; } = new List<KykalibrasyonPlani>();

    public virtual ICollection<KykalibrasyonPlani> KykalibrasyonPlaniReferansCihazs { get; set; } = new List<KykalibrasyonPlani>();

    public virtual ICollection<Lyaraclar> Lyaraclars { get; set; } = new List<Lyaraclar>();

    public virtual Miysahesaplar? Miysahesaplar { get; set; }

    public virtual Miysahesaplar? Musteri { get; set; }

    public virtual ICollection<SagirdiKontrolSonucu> SagirdiKontrolSonucus { get; set; } = new List<SagirdiKontrolSonucu>();

    public virtual SateklifSiparisTeslimatHareketi? SateklifSiparisTeslimatHareketi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SorumlusuNavigation { get; set; }

    public virtual Uyurunler? Urun { get; set; }

    public virtual UyurunMarkasi? UrunMarkasi { get; set; }

    public virtual ICollection<UyisAkisSorulari> UyisAkisSorularis { get; set; } = new List<UyisAkisSorulari>();

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileris { get; set; } = new List<UyisAkisVerileri>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviEkipmen { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasiArsivi> UyisEmriRotasiArsiviMakinas { get; set; } = new List<UyisEmriRotasiArsivi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiEkipmen { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UyisEmriRotasi> UyisEmriRotasiMakinas { get; set; } = new List<UyisEmriRotasi>();

    public virtual ICollection<UymakinaIslemTuru> UymakinaIslemTurus { get; set; } = new List<UymakinaIslemTuru>();

    public virtual ICollection<UyurunEkipmanlari> UyurunEkipmanlaris { get; set; } = new List<UyurunEkipmanlari>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiEkipmen { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<UyurunRotasi> UyurunRotasiMakinas { get; set; } = new List<UyurunRotasi>();

    public virtual ICollection<YmbakimEkibi> YmbakimEkibis { get; set; } = new List<YmbakimEkibi>();

    public virtual ICollection<UyislemTuru> Islems { get; set; } = new List<UyislemTuru>();
}
