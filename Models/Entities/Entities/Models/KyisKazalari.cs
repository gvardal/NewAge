using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class KyisKazalari
{
    public int IsKazasiId { get; set; }

    public byte? OlayTuru { get; set; }

    public short? KazaKategorisiId { get; set; }

    public short? KazaTipiId { get; set; }

    public DateTime? OlayTarihi { get; set; }

    public string? VardiyaKodu { get; set; }

    public int? CalisanId { get; set; }

    public short? DepartmanId { get; set; }

    public short? UnvanId { get; set; }

    public int? KonumId { get; set; }

    public string? Konu { get; set; }

    public string? KazaBilgileri { get; set; }

    public byte[]? KazaResim1 { get; set; }

    public byte[]? KazaResim2 { get; set; }

    public byte[]? KazaResim3 { get; set; }

    public byte[]? KazaResim4 { get; set; }

    public string? OlayinGerceklestigiYer { get; set; }

    public int? MakineEkipmanId { get; set; }

    public short? Proses { get; set; }

    public short? SurecId { get; set; }

    public int? GerceklesenOperasyon { get; set; }

    public short? OlaySirasindakiIslemTuruId { get; set; }

    public short? TehlikeliMadde { get; set; }

    /// <summary>
    /// 1-Dikkatsizlik - İlgi Eksikliği 2-Eğitim-Bilgi Eksikliği 3-Güvensiz / Tehlikeli Hareket 4-Güvensiz / Tehlikeli Koşul 5-İş Planlama Eksikliği 6-KKD Kullanmama 7-Koruyucu Eksikliği 8-LOTO / EKED Uygulamama 9-Mesleki Yetersizlik 10-Talimata Uygun Çalışmama 11-Taşeron Seçimi ve Gözetimi Yanlışlığı 12-Yetersiz Makine Koruyucusu
    /// </summary>
    public byte? KazaNedeni { get; set; }

    public DateTime? IseBaslamaZamani { get; set; }

    public string? IslemSikligi { get; set; }

    public decimal? YaklasikMaliyet { get; set; }

    /// <summary>
    /// 1-3 günden az istirahat gerekir 2-3 günden fazla istirahat gerekir 3-İşbaşı yapabilir
    /// </summary>
    public byte? Sonuc { get; set; }

    public string? GorguTaniklarininAdlari { get; set; }

    public string? GorguTaniklarininIfadeleri { get; set; }

    public string? YapilanMedikalIslemler { get; set; }

    public string? SevkAciklama { get; set; }

    public string? YaralanmaAciklamasi { get; set; }

    public short? YaralanmaSekli { get; set; }

    public byte? VucutKismi { get; set; }

    public byte? VucutTarafi { get; set; }

    public bool? OlumluKaza { get; set; }

    public DateTime? OlumTarihi { get; set; }

    public bool? BildirimiZorunlu { get; set; }

    public bool? OzelDurum { get; set; }

    public byte? KayipGunSayisi { get; set; }

    public DateTime? IzinBaslangicTarihi { get; set; }

    public DateTime? IzinBitisTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual Ikorganizasyonlar? Departman { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PFislemTuru? GerceklesenOperasyonNavigation { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Fdemirba? MakineEkipman { get; set; }

    public virtual ICollection<PKycalisanIsKazaKutugu> PKycalisanIsKazaKutugus { get; set; } = new List<PKycalisanIsKazaKutugu>();

    public virtual Kysurecler? ProsesNavigation { get; set; }

    public virtual PKytehlikeliMadde? TehlikeliMaddeNavigation { get; set; }

    public virtual Ikunvanlar? Unvan { get; set; }

    public virtual PKyvucutKismi? VucutKismiNavigation { get; set; }

    public virtual PKyvucutTarafi? VucutTarafiNavigation { get; set; }

    public virtual PKyyaralanmaSekli? YaralanmaSekliNavigation { get; set; }
}
