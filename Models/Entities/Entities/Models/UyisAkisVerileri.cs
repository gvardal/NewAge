using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyisAkisVerileri
{
    public int IsAkisVeriId { get; set; }

    public long? EgitimKatilimciId { get; set; }

    public int? IsEmriRotaId { get; set; }

    public int? BakimPlaniId { get; set; }

    public int? IcTetkikPlaniId { get; set; }

    public long? EnvanterId { get; set; }

    public long? TeslimatHareketiId { get; set; }

    public short? IsAkisSoruId { get; set; }

    public string? OrnekSeriNo { get; set; }

    public short? OrnekAlmaPlaniId { get; set; }

    public short? OrnekSayisi { get; set; }

    public decimal? MinimumDeger { get; set; }

    public decimal? MaksimumDeger { get; set; }

    public string? OlcumTuru { get; set; }

    public string? OlcumSikligi { get; set; }

    public int? OlcuCihazi { get; set; }

    public string? ParcadakiYeri { get; set; }

    /// <summary>
    /// Değer=0 Onay=1
    /// </summary>
    public bool? KontrolTipi { get; set; }

    public string? Deger { get; set; }

    /// <summary>
    /// İş akış sorularında kullanıcının cevabı doğru iste true yanlış ise false boş ise null değeri gelir.
    /// </summary>
    public bool? Sonuc { get; set; }

    public string? Seviye { get; set; }

    public int? Onay { get; set; }

    public short? KabulEdilenMiktar { get; set; }

    public short? ReddedilenMiktar { get; set; }

    public string? Aciklama { get; set; }

    public string? Aciklama2 { get; set; }

    public string? Aciklama3 { get; set; }

    public string? Aciklama4 { get; set; }

    public string? Aciklama5 { get; set; }

    public string? EklentiDosyaAdi { get; set; }

    public string? EklentiDosyaAdi2 { get; set; }

    public string? EklentiDosyaAdi3 { get; set; }

    public int? Dofid { get; set; }

    public int? DenetleyenId { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual ByyillikBakimPlani? BakimPlani { get; set; }

    public virtual Ikcalisanlar? Denetleyen { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual IkegitimKatilimciListesi? EgitimKatilimci { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual YmmusteriEnvanter? Envanter { get; set; }

    public virtual KyicTetkikPlani? IcTetkikPlani { get; set; }

    public virtual UyisAkisSorulari? IsAkisSoru { get; set; }

    public virtual Fdemirba? OlcuCihaziNavigation { get; set; }

    public virtual KyornekAlmaPlani? OrnekAlmaPlani { get; set; }

    public virtual ICollection<UyisAkisOlcumDegerleri> UyisAkisOlcumDegerleris { get; set; } = new List<UyisAkisOlcumDegerleri>();
}
