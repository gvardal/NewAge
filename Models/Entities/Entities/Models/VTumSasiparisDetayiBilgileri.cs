using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VTumSasiparisDetayiBilgileri
{
    public byte? FirmaId { get; set; }

    public int? TeklifSiparisId { get; set; }

    public long TeklifSiparisDetayiId { get; set; }

    public string? TeklifSiparisKoduTuru { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public string? FirmaAdi { get; set; }

    public string? Konu { get; set; }

    public long? GenelTalepId { get; set; }

    public string? UrunKoduAdi { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public decimal? KalanMiktar { get; set; }

    public string? OlcuBirimi { get; set; }

    public decimal? BirimFiyat { get; set; }

    public double? IskontoOrani { get; set; }

    public string? SiparisDetayDurumu { get; set; }

    public string? SiparisDurumu { get; set; }

    public string? VergiTuru { get; set; }

    public double IskontoluBirimFiyat { get; set; }

    public decimal? ToplamFiyat { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public string? Sembolu { get; set; }

    public decimal? DovizKarsiligi { get; set; }

    public decimal? KurOrani { get; set; }

    public string? Aciklama { get; set; }

    public string? EkAciklama { get; set; }

    public int? UrunId { get; set; }
}
