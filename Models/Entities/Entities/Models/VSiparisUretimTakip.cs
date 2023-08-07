using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSiparisUretimTakip
{
    public long? SiparisDetayiId { get; set; }

    public int? SiparisKodu { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public string? SiparisTuru { get; set; }

    public decimal? SiparisMiktari { get; set; }

    public decimal? SevkEdilenMiktar { get; set; }

    public string? OlcuBirimi { get; set; }

    public string? FirmaAdi { get; set; }

    public string? Konu { get; set; }

    public string? Aciklama { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public string? Marka { get; set; }

    public string? SehirAdi { get; set; }

    public string? SatisElemani { get; set; }

    public string? MusteriTemsilcisi { get; set; }

    public double? GenelUretimMaliyetParametresi { get; set; }

    public string? HesapKodu { get; set; }

    public string? Uyari { get; set; }

    public double? IskontoluBirimFiyat { get; set; }

    public decimal? Toplam { get; set; }

    public decimal? ListeFiyati { get; set; }

    public decimal? SonKullaniciFiyati { get; set; }

    public decimal? BayiFiyati { get; set; }

    public decimal? CozumOrtagiFiyati { get; set; }

    public decimal? ProjeFiyati { get; set; }

    public string? Durum { get; set; }
}
