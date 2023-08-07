using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSysiparisSiparisDetayiTeslimatPlani
{
    public int? SiparisId { get; set; }

    public DateTime? SiparisTarihi { get; set; }

    public int? MusteriKoduId { get; set; }

    public string? FirmaAdi { get; set; }

    public int FirmaId { get; set; }

    public long SiparisDetayiId { get; set; }

    public int? UrunKodu { get; set; }

    public string? SiparisDetayiUrunKoduAdi { get; set; }

    public decimal? SiparisMiktari { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public string? CizimNo { get; set; }

    public string? ResimNo { get; set; }

    public int? ProjeKodu { get; set; }

    public short? SiraNo { get; set; }

    public long? SevkiyatPlaniId { get; set; }

    public short? RevizyonNo { get; set; }

    public short? TeslimatPlaniSiraNo { get; set; }

    public int? TeslimatPlaniUrunId { get; set; }

    public decimal? TeslimatPlaniMiktar { get; set; }

    public string? OlcuKodu { get; set; }

    public string? TeslimatPlaniUrunKoduAdi { get; set; }

    public string? TeslimatPlaniUrunResimNo { get; set; }

    public DateTime? TeslimatPlaniTerminTarihi { get; set; }

    public decimal? TaserondakiMiktar { get; set; }

    public decimal? SevkEdilenMiktar { get; set; }

    public decimal? PaketlenmisMiktar { get; set; }

    public decimal? UretimMiktari { get; set; }

    public bool? SeciliFason { get; set; }

    public bool? SeciliBarkod { get; set; }

    public bool? SeciliPaket { get; set; }

    public byte? DurumId { get; set; }

    public string? KonumKodu { get; set; }

    public string? Ad { get; set; }

    public string? KonumKoduAdi { get; set; }

    public string? SiparisDetayi { get; set; }

    public string? SiparisDetayiUrunKodu { get; set; }

    public string? TeslimatPlaniUrunKodu { get; set; }

    public string? TeslimatPlaniUrunAdi { get; set; }

    public byte? PlanlananSevkiyatAracSayisi { get; set; }

    public byte? GerceklesenSevkiyatAracSayisi { get; set; }

    public string? EkAlan3 { get; set; }

    public decimal? KalanMiktar { get; set; }
}
