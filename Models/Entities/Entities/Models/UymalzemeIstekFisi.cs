using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UymalzemeIstekFisi
{
    public long MalzemeIstekFisiId { get; set; }

    public byte? FirmaId { get; set; }

    public DateTime? Tarih { get; set; }

    public int? SiparisNo { get; set; }

    public long? IsEmriNo { get; set; }

    public int? TalepEden { get; set; }

    public int? TeslimEden { get; set; }

    /// <summary>
    /// NULL= Malzeme İstek Fişi,1=Proje Malzeme İhtiyaç Planı,
    /// </summary>
    public byte? TuruId { get; set; }

    public int? MiysahesapId { get; set; }

    public int? KonumId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? ProjeId { get; set; }

    public long? UretimPlaniId { get; set; }

    public long? KesimIsEmriNo { get; set; }

    public string? MalzemeIstekFisiKodu { get; set; }

    public DateTime? YazdirmaTarihi { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

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

    public virtual UyisEmri? IsEmriNoNavigation { get; set; }

    public virtual UyuretimPlani? KesimIsEmriNoNavigation { get; set; }

    public virtual Uykonum? Konum { get; set; }

    public virtual Miysahesaplar? Miysahesap { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual Sysiparisler? SiparisNoNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? TalepEdenNavigation { get; set; }

    public virtual Ikcalisanlar? TeslimEdenNavigation { get; set; }

    public virtual UyuretimPlani? UretimPlani { get; set; }

    public virtual ICollection<UymalzemeIstekFisiDetayi> UymalzemeIstekFisiDetayis { get; set; } = new List<UymalzemeIstekFisiDetayi>();

    public virtual ICollection<UystokHareketi> UystokHareketis { get; set; } = new List<UystokHareketi>();
}
