using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VMusteriEnvanterServisListesi
{
    public long BakimPlaniLotNoId { get; set; }

    public int BakimPlaniId { get; set; }

    public long BakimPlaniDetayiId { get; set; }

    public long? EnvanterId { get; set; }

    public string? YapilanIslem { get; set; }

    public byte? YapilanIslemId { get; set; }

    public string? Sonuc { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? KontrolEdilenMiktar { get; set; }

    public DateTime? IslemTarihi { get; set; }

    public string? BarkodNo { get; set; }

    public string? UrunKontrolGovde { get; set; }

    public string? UrunKontrolPaket { get; set; }

    public string? UrunKontrolIcAksam { get; set; }

    public string? UrunKontrolEvrak { get; set; }

    public string? AdiSoyadi { get; set; }

    public int? CalisanId { get; set; }

    public string? ServisTuru { get; set; }

    public string? Durumu { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public string? UnvanIi { get; set; }

    public string? FirmaAdi { get; set; }
}
