using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SagirdiKontrolSonucu
{
    public long GirdiKontrolId { get; set; }

    public long? HareketReferansId { get; set; }

    public int? UrunId { get; set; }

    public byte? ZincirKodu { get; set; }

    public short? AlternatifRotaId { get; set; }

    public long? MusteriEnvanterId { get; set; }

    public string? KaliteKontrolTalimatlari { get; set; }

    public string? MinDeger { get; set; }

    public string? MaksDeger { get; set; }

    public short? OrnekSayisi { get; set; }

    public string? OlcumCihazi { get; set; }

    public int? OlcumCihaziId { get; set; }

    public string? DegerlendirmeSonucu { get; set; }

    public string? Deger { get; set; }

    public bool? Sonuc { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual SateklifSiparisTeslimatHareketi? HareketReferans { get; set; }

    public virtual YmmusteriEnvanter? MusteriEnvanter { get; set; }

    public virtual Fdemirba? OlcumCihaziNavigation { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual UyurunRotasi? UyurunRotasi { get; set; }
}
