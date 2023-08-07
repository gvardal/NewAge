using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeAdimlariHavuzu
{
    public int ProjeAdimiId { get; set; }

    public string? Konu { get; set; }

    public string? IsinAdi { get; set; }

    public int? KilometreTasi { get; set; }

    public int? ProjeKodu { get; set; }

    public int? OncekiProjeAdimi { get; set; }

    public byte? ProjeAdimiDurumuId { get; set; }

    public byte? ProjeAdimiTuruId { get; set; }

    public string? Onem { get; set; }

    public int? BaslamaSuresiGunFarki { get; set; }

    public int? PlanlananSure { get; set; }

    public int? Sorumlu { get; set; }

    public short? ProjeGoreviId { get; set; }

    public short? ProjeTakimiId { get; set; }

    public decimal? TahminiMaliyeti { get; set; }

    public byte? KrediPuani { get; set; }

    public string? Onculler { get; set; }

    public string? TeslimHukumleri { get; set; }

    public string? Yorumlar { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual ICollection<PyprojeAdimlariHavuzu> InverseKilometreTasiNavigation { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual ICollection<PyprojeAdimlariHavuzu> InverseOncekiProjeAdimiNavigation { get; set; } = new List<PyprojeAdimlariHavuzu>();

    public virtual PyprojeAdimlariHavuzu? KilometreTasiNavigation { get; set; }

    public virtual PyprojeAdimlariHavuzu? OncekiProjeAdimiNavigation { get; set; }

    public virtual PPyprojeAdimiDurumu? ProjeAdimiDurumu { get; set; }

    public virtual PPyprojeAdimiTuru? ProjeAdimiTuru { get; set; }

    public virtual PPyprojeGorevleri? ProjeGorevi { get; set; }

    public virtual PyprojeHavuzu? ProjeKoduNavigation { get; set; }

    public virtual PPyprojeTakimlari? ProjeTakimi { get; set; }

    public virtual ICollection<PyaksiyonHavuzuDokumanlari> PyaksiyonHavuzuDokumanlaris { get; set; } = new List<PyaksiyonHavuzuDokumanlari>();

    public virtual ICollection<PyaksiyonHavuzuRiskleri> PyaksiyonHavuzuRiskleris { get; set; } = new List<PyaksiyonHavuzuRiskleri>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }

    public virtual Ikcalisanlar? SorumluNavigation { get; set; }
}
