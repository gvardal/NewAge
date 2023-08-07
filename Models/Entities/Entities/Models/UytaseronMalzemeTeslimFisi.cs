using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UytaseronMalzemeTeslimFisi
{
    public int TaseronMalzemeTeslimFisiId { get; set; }

    public int? TaseronId { get; set; }

    public DateTime? SevkiyatTarih { get; set; }

    public int? SevkEdenCalisanId { get; set; }

    public byte? HazirAciklamalar { get; set; }

    public string? Aciklama { get; set; }

    public int? TasiyiciFirmaId { get; set; }

    public int? UretimFirmaId { get; set; }

    public string? SoforTckn { get; set; }

    public string? SoforAdi { get; set; }

    public string? SoforSoyadi { get; set; }

    public string? GonderiKodu { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public byte? DurumId { get; set; }

    public long? SevkiyatIrsaliyeId { get; set; }

    public long? FaturaId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public string? EklentiDosyaAdi1 { get; set; }

    public string? EklentiDosyaAdi2 { get; set; }

    public string? EklentiDosyaAdi3 { get; set; }

    public bool? KaliteOnay { get; set; }

    public int? KaliteOnaylayan { get; set; }

    public DateTime? KaliteOnayTarihi { get; set; }

    public bool? UretimOnay { get; set; }

    public int? UretimOnaylayan { get; set; }

    public DateTime? UretimOnayTarihi { get; set; }

    public bool? LojistikOnay { get; set; }

    public int? LojistikOnaylayan { get; set; }

    public DateTime? LojistikOnayTarihi { get; set; }

    public virtual PUytaseronMalzemeTeslimDurumu? Durum { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<Fyfatura> Fyfaturas { get; set; } = new List<Fyfatura>();

    public virtual PUytaseronMalzemeAciklamasi? HazirAciklamalarNavigation { get; set; }

    public virtual Ikcalisanlar? KaliteOnaylayanNavigation { get; set; }

    public virtual Ikcalisanlar? LojistikOnaylayanNavigation { get; set; }

    public virtual Ikcalisanlar? SevkEdenCalisan { get; set; }

    public virtual Fyfatura? SevkiyatIrsaliye { get; set; }

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Miysahesaplar? Taseron { get; set; }

    public virtual Miysahesaplar? TasiyiciFirma { get; set; }

    public virtual Miysahesaplar? UretimFirma { get; set; }

    public virtual Ikcalisanlar? UretimOnaylayanNavigation { get; set; }

    public virtual ICollection<UytaseronMalzemeTeslimFisiDetayi> UytaseronMalzemeTeslimFisiDetayis { get; set; } = new List<UytaseronMalzemeTeslimFisiDetayi>();
}
