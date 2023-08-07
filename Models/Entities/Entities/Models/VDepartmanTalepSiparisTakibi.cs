using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VDepartmanTalepSiparisTakibi
{
    public int? SatinAlmaTalebiId { get; set; }

    public DateTime? TalepTarihi { get; set; }

    public string? AdiSoyadi { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public string? Aciklama { get; set; }

    public decimal? TalepEdilenMiktar { get; set; }

    public int? SiparisId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public string? FirmaAdi { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public DateTime? GerceklesenTeslimatTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public byte? Durumu { get; set; }

    public bool? OnKabul { get; set; }
}
