using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class FyvFatura
{
    public string? FirmaAdi { get; set; }

    public string? Adi { get; set; }

    public string? OlcuBirimi { get; set; }

    public long FaturaId { get; set; }

    public decimal? Miktari { get; set; }

    public byte? KdvOrani { get; set; }

    public decimal? Toplam { get; set; }

    public string? GenelToplamYazi { get; set; }

    public string? VergiDairesi { get; set; }

    public string? VergiNo { get; set; }

    public string? Telefon1 { get; set; }

    public string? Faks { get; set; }

    public string? Fadres { get; set; }

    public string? FpostaKodu { get; set; }

    public string? SehirAdi { get; set; }

    public string? Ad { get; set; }

    public string? UrunKodu { get; set; }

    public DateTime? IrsDuzenlemeTarihi { get; set; }

    public decimal? DovizFiyati { get; set; }

    public string? Sembolu { get; set; }

    public double? IskontoOrani { get; set; }

    public double? IskontoluBirimFiyat { get; set; }

    public byte? Id { get; set; }
}
