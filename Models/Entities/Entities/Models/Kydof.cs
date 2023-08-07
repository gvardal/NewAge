using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Kydof
{
    public int Dofid { get; set; }

    public int? MusteriIstekSikayetId { get; set; }

    public int? IcTetkikPlaniDetayiId { get; set; }

    public long? UygunsuzUrunHizmetId { get; set; }

    public byte Durum { get; set; }

    /// <summary>
    /// 1=Düzeltici Faaliyet, 2=Öneri, 3=Risk, 4=Örnek Uygulama, 5=İyileştirme, 6=Kök Neden Analizi
    /// </summary>
    public string? DofTuru { get; set; }

    public DateTime? BildirimTarihi { get; set; }

    public int? BildirenCalisanId { get; set; }

    public string? Konu { get; set; }

    public string? ProblemTanimi { get; set; }

    public short? IlgiliSurecId { get; set; }

    public string? DosyaAdi { get; set; }

    public string? DosyaAdi2 { get; set; }

    public string? DosyaAdi3 { get; set; }

    public decimal? HataUrunSayisi { get; set; }

    public int? FaaliyetLideriId { get; set; }

    public string? IidigerIlgiliUrunlerinIncelenmesi { get; set; }

    public string? IiiilkAnalizInceleme { get; set; }

    public string? IvacilEylemPlanlari { get; set; }

    public int? Onaylayan { get; set; }

    public string? OlayinEtkileri { get; set; }

    public string? UygulanacakFaaliyet { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public string? Sonuc { get; set; }

    public string? EylemlerinIzlenmesiveDegerlendirilmesi { get; set; }

    public int? DegerlendirenId { get; set; }

    public DateTime? KapanisTarihi { get; set; }

    public byte? DofkalitesiPuani { get; set; }

    public int? YeniDof { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? BildirenCalisan { get; set; }

    public virtual Ikcalisanlar? Degerlendiren { get; set; }

    public virtual PKydofdurum DurumNavigation { get; set; } = null!;

    public virtual Ikcalisanlar? FaaliyetLideri { get; set; }

    public virtual ICollection<Ggorevler> Ggorevlers { get; set; } = new List<Ggorevler>();

    public virtual Kysurecler? IlgiliSurec { get; set; }

    public virtual ICollection<Kydof> InverseYeniDofNavigation { get; set; } = new List<Kydof>();

    public virtual ICollection<KykokNedenAnalizi> KykokNedenAnalizis { get; set; } = new List<KykokNedenAnalizi>();

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual YmmusteriIstekSikayetleri? MusteriIstekSikayet { get; set; }

    public virtual Ikcalisanlar? OnaylayanNavigation { get; set; }

    public virtual ICollection<RyacilDurumSenaryolari> RyacilDurumSenaryolaris { get; set; } = new List<RyacilDurumSenaryolari>();

    public virtual KyuygunsuzUrunHizmet? UygunsuzUrunHizmet { get; set; }

    public virtual Kydof? YeniDofNavigation { get; set; }
}
