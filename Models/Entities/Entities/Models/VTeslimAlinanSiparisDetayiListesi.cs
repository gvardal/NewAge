using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VTeslimAlinanSiparisDetayiListesi
{
    public long HareketReferansiId { get; set; }

    public int? SatinAlmaTalebiId { get; set; }

    public long? MalzemeIhtiyacPlaniId { get; set; }

    public long TeklifSiparisDetayiId { get; set; }

    public int SiparisId { get; set; }

    public byte? FirmaId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public string UrunKoduAdi { get; set; } = null!;

    public int? MalzemeUrunAdi { get; set; }

    public int? TedarikciKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public decimal? PlanlananMiktar { get; set; }

    public DateTime? PlanlananTeslimatTarihi { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public DateTime? GerceklesenTeslimatTarihi { get; set; }

    public string? KontrolSonucu { get; set; }

    public bool? Secildi { get; set; }

    public bool? Irsaliyelendirildi { get; set; }

    public string? SevkiyatDogrulamaTuru { get; set; }

    public bool? OnKabul { get; set; }

    public decimal? KoliAdedi { get; set; }

    public string? Upc { get; set; }

    public string? Upckoli { get; set; }

    public decimal? DisKutuAdedi { get; set; }

    public string? Aciklama { get; set; }

    public byte? KullanimTuruId { get; set; }

    public short? GirdiKaliteKontrolSoruGrubuId { get; set; }
}
