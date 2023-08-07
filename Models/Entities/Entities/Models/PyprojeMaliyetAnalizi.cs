using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PyprojeMaliyetAnalizi
{
    public int ProjeMaliyetAnaliziId { get; set; }

    public short? MaliyetTuruId { get; set; }

    public int? ProjeAdimiId { get; set; }

    public int? ProjeId { get; set; }

    public string? MaliyetAdi { get; set; }

    public string? MaliyetAciklamasi { get; set; }

    public string? MaliyetGerekcesi { get; set; }

    public string? AlinacakKurulus { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public int? OlcuBirimiId { get; set; }

    public decimal? PlanlananDovizFiyati { get; set; }

    public byte? PlanlananParaBirimiId { get; set; }

    public decimal? PlanlananKurOrani { get; set; }

    public decimal? PlanlananBirimFiyati { get; set; }

    public decimal? PlanlananToplamTutar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? GerceklesenBirimFiyati { get; set; }

    /// <summary>
    /// (isnull([GerceklesenMiktar]*[GerceklesenBirimFiyati],(0.00)))
    /// </summary>
    public decimal? GerceklesenToplamTutar { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }

    public virtual Ikcalisanlar? DuzenleyenCalisan { get; set; }

    public virtual Ikcalisanlar? EkleyenCalisan { get; set; }

    public virtual PolcuBirimleri? OlcuBirimi { get; set; }

    public virtual PparaBirimi? PlanlananParaBirimi { get; set; }

    public virtual Pyprojeler? Proje { get; set; }

    public virtual PyprojeAdimlari? ProjeAdimi { get; set; }

    public virtual ICollection<SasatinAlmaTalebi> SasatinAlmaTalebis { get; set; } = new List<SasatinAlmaTalebi>();

    public virtual Ikcalisanlar? SonErisenCalisan { get; set; }
}
