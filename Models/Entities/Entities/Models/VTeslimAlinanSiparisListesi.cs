using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VTeslimAlinanSiparisListesi
{
    public byte? FirmaId { get; set; }

    public int SiparisId { get; set; }

    public string? FirmaAdi { get; set; }

    public int? TedarikciId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public DateTime? GerceklesenTeslimatTarihi { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public int? KonumId { get; set; }

    public byte? Durum { get; set; }

    public string? Ad { get; set; }

    public string? TalepDurumu { get; set; }

    public int? TeklifSiparisTuruId { get; set; }

    public string? TeklifSiparisKoduTuru { get; set; }

    public string? AdiSoyadi { get; set; }

    public int? TalepEden { get; set; }

    public string? Konu { get; set; }

    public byte? KullanimTuruId { get; set; }
}
