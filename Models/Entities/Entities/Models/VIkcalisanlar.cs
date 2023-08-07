using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VIkcalisanlar
{
    public int Id { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public int? HesapId { get; set; }

    public string? KontakTuru { get; set; }

    public string? Kunvani { get; set; }

    public string? Kdepartmani { get; set; }

    public DateTime? OzgecmisKayitTarihi { get; set; }

    public string? OzgecmisBasligi { get; set; }

    public string? KariyerHedefi { get; set; }

    public string? AramaKelmeleri { get; set; }

    public string? BasvuruTuru { get; set; }

    public string? TercihEdilenCalismaSekli { get; set; }

    public string? TercihEdilenCalismaPozisyon { get; set; }

    public bool? CalisanTuru { get; set; }

    public bool? Personel { get; set; }

    public bool? Kontak { get; set; }

    public string? BarkodNo { get; set; }

    public string? Durumu { get; set; }

    public string? TckimlikNo { get; set; }

    public string? Adi { get; set; }

    public string? Soyadi { get; set; }

    public string? IlkSoyadi { get; set; }

    public string? KullaniciAdi { get; set; }

    public string? Sifresi { get; set; }

    public byte? BagliOlduguSube { get; set; }

    public byte? IsAlaniId { get; set; }

    public short? Birimi { get; set; }

    public short? Unvani { get; set; }

    public short? Vekaleti { get; set; }

    public string? Sskno { get; set; }

    public string? Aktif { get; set; }

    public DateTime? SskbaslangicTarihi { get; set; }

    public DateTime? IseGirisTarihi { get; set; }

    public DateTime? AyrilmaTarihi { get; set; }

    public string? IstenCikisKodu { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? Cinsiyeti { get; set; }

    public string? KanGrubu { get; set; }

    public string? MedeniDurumu { get; set; }

    public DateTime? EvlilikTarihi { get; set; }

    public string? AskerlikDurumu { get; set; }

    public DateTime? AskerlikTarihi { get; set; }

    public string? Adresi { get; set; }

    public string? PostaKodu { get; set; }

    public int? Ilce { get; set; }

    public int? Sehir { get; set; }

    public short? Ulke { get; set; }

    public string? EPosta { get; set; }

    public string? Msn { get; set; }

    public string? EvTelefonu { get; set; }

    public string? CepTelefonu { get; set; }

    public string? IsTelefonu { get; set; }

    public string? DahiliNo { get; set; }

    public string? AcilKontakAdi { get; set; }

    public string? AcilKontakSoyadi { get; set; }

    public string? AcilKontakTelefonu { get; set; }

    public bool? OzelDurumEngelli { get; set; }

    public bool? OzelDurumHukumlu { get; set; }

    public bool? OzelDurumTeror { get; set; }

    public string? Uyruk { get; set; }

    public string? SurucuEhliyetSinifi { get; set; }

    public bool? Cocuk { get; set; }

    public byte? CocukSayisi { get; set; }

    public bool? SaglikProblemi { get; set; }

    public string? SaglikProblemiAciklama { get; set; }

    public bool? SeyhatEdebilirlik { get; set; }

    public bool? SigaraKullanimi { get; set; }

    public bool? CokUlusluSirketDeneyimi { get; set; }

    public bool? YurtDisiDeneyimi { get; set; }

    public string? WebAdresi { get; set; }

    public string? UyeOlunanDernekKlupler { get; set; }

    public string? AlinanBursOduller { get; set; }

    public string? Yayinlar { get; set; }

    public string? Notlar { get; set; }

    public string? UcretBeklenti { get; set; }

    public string? OzgecmisDosyaYolu { get; set; }

    public byte? OdemeSikligi { get; set; }

    public byte? CalismaGrubuId { get; set; }

    public bool? MaasBayragi { get; set; }

    public string? BordroHesaplamaTuru { get; set; }

    public bool? BrutNet { get; set; }

    public decimal? AylikUcreti { get; set; }

    public decimal? NetUcreti { get; set; }

    public decimal? SaatlikUcreti { get; set; }

    public decimal? PrimUcreti { get; set; }

    public decimal? ToplamIzinGunu { get; set; }

    public decimal? DevirIzinGunu { get; set; }

    public decimal? KullanilanIzinGunu { get; set; }

    public decimal? IzinGunu { get; set; }

    public decimal? ToplamIzinSaati { get; set; }

    public decimal? KullanilanIzinSaati { get; set; }

    public decimal? IzinSaati { get; set; }

    public short? RaporSaati { get; set; }

    public short? EksikSaati { get; set; }

    public short? FazlaSaati { get; set; }

    public byte? HaftasonuMesaiBakiyesi { get; set; }

    public bool? Yemek { get; set; }

    public bool? Servis { get; set; }

    public int? FymaasOdemeIslemTuruId { get; set; }

    public int? FykidemTazminatiIslemTuruId { get; set; }

    public int? FypersonelGiderleriHesabi { get; set; }

    public int? FypersonelSgkisverenHesabiId { get; set; }

    public int? FypersonelIssizlikIsVerenHesabiId { get; set; }

    public int? FypersonelPrimOdemeleriHesabiId { get; set; }

    public int? FypersonelKidemTazminatiHesabiId { get; set; }

    public int? FypersonelFazlaMesaiHesabiId { get; set; }

    public int? FyisAvansHesabi { get; set; }

    public int? FyucretAvansHesabi { get; set; }

    public int? FymasrafMerkeziId { get; set; }

    public bool? SatisTemcilsiBayragi { get; set; }

    public byte? BankaAdi { get; set; }

    public string? BankaHesapKodu { get; set; }

    public short? KonumId { get; set; }

    public int? BakimEkibiId { get; set; }

    public bool? Secili { get; set; }

    public bool? B2bizni { get; set; }

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
}
