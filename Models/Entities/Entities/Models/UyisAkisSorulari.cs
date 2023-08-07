using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisAkisSorulari
{
    public short IsAkisSoruId { get; set; }

    public short? SoruGrubuId { get; set; }

    public int? EgitimId { get; set; }

    public string? SoruTuru { get; set; }

    public string? Soru { get; set; }

    public string? Aciklama { get; set; }

    public bool? Aktif { get; set; }

    /// <summary>
    /// Değer=0 Onay=1
    /// </summary>
    public bool? KontrolTipi { get; set; }

    /// <summary>
    /// Onay,Değer, 5Li Ölçüm, 10lu Ölçüm, Evet/Hayır,Maksimum Değer, Minimum Değer, Aralık
    /// </summary>
    public string? KontrolOlcutu { get; set; }

    public short? OrnekAlmaPlaniId { get; set; }

    public short? OrnekSayisi { get; set; }

    public decimal? MinimumDeger { get; set; }

    public decimal? MaksimumDeger { get; set; }

    public byte? ZincirKodu { get; set; }

    /// <summary>
    /// 1-İş Başlangıcı
    /// 2-Vardiya Başı
    /// 3-Adet
    /// 4-Zaman
    /// 5-Rassal
    /// 6-Vardiya Sonu
    /// 7-İş Sonu
    /// 8-Bağımsız
    /// </summary>
    public string? OlcumTuru { get; set; }

    public string? OlcumSikligi { get; set; }

    public string? ParcadakiYeri { get; set; }

    public int? OlcuCihazi { get; set; }

    public string? DosyaAdi { get; set; }

    public byte[]? ResimDosyaAdi { get; set; }

    public string? Secenek1 { get; set; }

    public string? Secenek2 { get; set; }

    public string? Secenek3 { get; set; }

    public string? Secenek4 { get; set; }

    public string? Secenek5 { get; set; }

    public string? DogruSecenek { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual IkegitimKatalogu? Egitim { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Fdemirba? OlcuCihaziNavigation { get; set; }

    public virtual KyornekAlmaPlani? OrnekAlmaPlani { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UyisAkisSoruGruplari? SoruGrubu { get; set; }

    public virtual ICollection<UyisAkisVerileri> UyisAkisVerileris { get; set; } = new List<UyisAkisVerileri>();
}
