using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VTeslimAlinacakSiparisListesi
{
    public byte? FirmaId { get; set; }

    public int SiparisId { get; set; }

    public string? FirmaAdi { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public string? TeslimYeri { get; set; }

    public int? KonumId { get; set; }

    public string? Konu { get; set; }

    public int? Id { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public string Ekleyen { get; set; } = null!;

    public int? TeklifSiparisTuruId { get; set; }

    public byte? TeklifSiparisSekliId { get; set; }

    public string? TeklifSiparisTuruKodu { get; set; }

    public string? TeklifSiparisTuru { get; set; }

    public int? TalepEden { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public string? TeklifSiparisSekli { get; set; }
}
