using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyuretimVerileriArsivi
{
    public long UretimVerisiId { get; set; }

    public int? IsEmriRotasiId { get; set; }

    public DateTime? Tarih { get; set; }

    public decimal? Adet { get; set; }

    public decimal? Fire { get; set; }

    public int? FireTuruId { get; set; }

    public int? CevrimSuresi { get; set; }

    public int? StandartSure { get; set; }

    public long? IsciZamanKartiId { get; set; }

    public int? CalisanId { get; set; }

    public string? Vardiya { get; set; }

    public byte? DurusTuruId { get; set; }

    public decimal? Sicaklik { get; set; }

    public decimal? Nem { get; set; }

    public decimal? Basinc { get; set; }

    public decimal? Hiz { get; set; }

    public decimal? Tartim1 { get; set; }

    public string? ProsesNo { get; set; }

    public bool? KapakDurum { get; set; }

    public string? LotNumarasi { get; set; }

    public string? BarkodNo { get; set; }

    public string? OlcumDegeri1 { get; set; }

    public string? OlcumDegeri2 { get; set; }

    public string? OlcumDegeri3 { get; set; }

    public string? OlcumDegeri4 { get; set; }

    public string? OlcumDegeri5 { get; set; }

    public string? OlcumDegeri6 { get; set; }

    public string? OlcumDegeri7 { get; set; }

    public string? OlcumDegeri8 { get; set; }

    public string? OlcumDegeri9 { get; set; }

    public string? OlcumDegeri10 { get; set; }

    public bool? TopluKayit { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisimTarihi { get; set; }

    public virtual Ikcalisanlar? Calisan { get; set; }

    public virtual UydurusTuru? DurusTuru { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual UyfireTuru? FireTuru { get; set; }

    public virtual UyisEmriRotasiArsivi? IsEmriRotasi { get; set; }

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
