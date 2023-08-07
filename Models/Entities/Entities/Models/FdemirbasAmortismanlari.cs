using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FdemirbasAmortismanlari
{
    public int DemirbasAmortismanId { get; set; }

    public short? MaliYil { get; set; }

    public byte? MaliAy { get; set; }

    public int DemirbasId { get; set; }

    public double? AmortismanOrani { get; set; }

    public string? AmortismanYontemi { get; set; }

    public decimal? BaslangicMaliyeti { get; set; }

    public decimal? ToplamMaliyet { get; set; }

    public decimal? SabitKiymetMaliyetiDo { get; set; }

    public decimal? BirikmisAmortismanDo { get; set; }

    public decimal? NetDefterDegeriDo { get; set; }

    public decimal? SabitKiymetDegeriDs { get; set; }

    public decimal? BirikmisAmortismanDs { get; set; }

    public decimal? NetDefterDegeriDs { get; set; }

    public decimal? YillikAmortisman { get; set; }

    public decimal? ToplamBirikmisAmortisman { get; set; }

    public decimal? NetAktifDegeri { get; set; }

    public decimal? DonemselAmortisman { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

    public int? YevmiyeKaydiYapanId { get; set; }

    public long? YevmiyeDefteriId { get; set; }

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

    public virtual Fdemirba Demirbas { get; set; } = null!;

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual FyyevmiyeDefteri? YevmiyeDefteri { get; set; }

    public virtual Ikcalisanlar? YevmiyeKaydiYapan { get; set; }
}
