using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VTalepTeklifleri
{
    public long TeklifSiparisDetayiId { get; set; }

    public int SiparisId { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birim { get; set; }

    public decimal? BirimFiyat { get; set; }

    public byte? Kdvorani { get; set; }

    public decimal? ToplamFiyat { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public byte? ParaBirimi { get; set; }

    public decimal? DovizKarsiligi { get; set; }

    public decimal? KurOrani { get; set; }

    public string? EkAciklama { get; set; }

    public string? Tdfiyat { get; set; }

    public string? TdodemeKosulu { get; set; }

    public string? TdurunKalitesi { get; set; }

    public string? TdteslimZamani { get; set; }

    public bool? TeklifOnayi { get; set; }

    public long? GenelTalepId { get; set; }

    public string? FirmaAdi { get; set; }

    public int? MalzemeUrunAdi { get; set; }

    public byte? DurumId { get; set; }
}
