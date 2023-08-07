using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Kshedefler
{
    public int HedefId { get; set; }

    public int? OncekiHedefId { get; set; }

    public short? StratejikAmacId { get; set; }

    public short DonemId { get; set; }

    public int? PerformansDegerlendirmeId { get; set; }

    /// <summary>
    /// 1=firma Hedefi 2=Bölüm hedefi 3=Kişisel Hedef
    /// </summary>
    public byte HedefTipi { get; set; }

    public short? IlgiliBirimId { get; set; }

    public int? SorumluCalisanId { get; set; }

    public string HedefTanimi { get; set; } = null!;

    public string? TaahutEdilen { get; set; }

    public string? TanimlanmisBasariOlcusu { get; set; }

    public string? IlgiliPerspektif { get; set; }

    public DateTime BaslangicTarihi { get; set; }

    public DateTime BitisTarihi { get; set; }

    public short? AnahtarPerformansGostergesiId { get; set; }

    public string? OlcumSekli { get; set; }

    public decimal? BaslangicDegeri { get; set; }

    public DateTime? BaslangicDegeriTarihi { get; set; }

    public decimal? HedeflenenDeger { get; set; }

    public DateTime? HedeflenenDegerTarih { get; set; }

    public decimal? AltSinir { get; set; }

    public DateTime? AltSinirTarih { get; set; }

    public decimal? UstSinir { get; set; }

    public DateTime? UstSinirTarih { get; set; }

    public decimal? GerceklesenDeger { get; set; }

    public DateTime? GerceklesenDegerTarih { get; set; }

    public decimal? TamamlanmaOrani { get; set; }

    public decimal? Agirligi { get; set; }

    public int? DegerlendirenId { get; set; }

    public DateTime? DegerlendirmeTarihi { get; set; }

    public string? Degerlendirme { get; set; }

    public byte? DegerlendirmePuani { get; set; }

    public int? OnaylayanId { get; set; }

    public bool? Onaylandi { get; set; }

    public DateTime? OnayTarihi { get; set; }

    public bool? Aktif { get; set; }

    public string? KokpitDosyaAdi { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public virtual KsanahtarPerformansGostergeleri? AnahtarPerformansGostergesi { get; set; }

    public virtual Ikcalisanlar? Degerlendiren { get; set; }

    public virtual Ikpysdonemler Donem { get; set; } = null!;

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikorganizasyonlar? IlgiliBirim { get; set; }

    public virtual ICollection<Kshedefler> InverseOncekiHedef { get; set; } = new List<Kshedefler>();

    public virtual ICollection<KsanahtarPerformansGostergeleri> KsanahtarPerformansGostergeleriKisiselHedefs { get; set; } = new List<KsanahtarPerformansGostergeleri>();

    public virtual ICollection<KsanahtarPerformansGostergeleri> KsanahtarPerformansGostergeleriKurumsalHedefs { get; set; } = new List<KsanahtarPerformansGostergeleri>();

    public virtual ICollection<KshedefOlcumleri> KshedefOlcumleris { get; set; } = new List<KshedefOlcumleri>();

    public virtual Ikcalisanlar? Onaylayan { get; set; }

    public virtual Kshedefler? OncekiHedef { get; set; }

    public virtual IkpysperformansDegerlendirme? PerformansDegerlendirme { get; set; }

    public virtual ICollection<Pyprojeler> Pyprojelers { get; set; } = new List<Pyprojeler>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SorumluCalisan { get; set; }

    public virtual KsstratejikAmaclar? StratejikAmac { get; set; }
}
