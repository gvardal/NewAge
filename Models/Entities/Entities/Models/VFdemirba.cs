using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VFdemirba
{
    public int DemirbasId { get; set; }

    public byte? FirmaId { get; set; }

    public int? BagliOlduguDemirbasId { get; set; }

    public string DemirbasKoduAdi { get; set; } = null!;

    public string? DemirbasKodu { get; set; }

    public string? BarkodNo { get; set; }

    public string? Rfidno { get; set; }

    public string? DemirbasAdi { get; set; }

    public string? SeriNo { get; set; }

    public string? Islevi { get; set; }

    public DateTime? EdinmeTarihi { get; set; }

    public byte? DemirbasTuru { get; set; }

    public byte? DemirbasDurumu { get; set; }

    public int? MiysahesaplarId { get; set; }

    public int? DemirbasKategorisiId { get; set; }

    public int? UrunId { get; set; }

    public short? UrunMarkasiId { get; set; }

    public string? Aciklama { get; set; }

    public string? Aciklama2 { get; set; }

    public string? DosyaSaklamaYeri { get; set; }

    public byte? KalipGozSayisi { get; set; }

    public short? IlgiliDepartman { get; set; }

    public int? Konumu { get; set; }

    public short? IlgiliUnvan { get; set; }

    public int? Sorumlusu { get; set; }

    public string? Kapasitesi { get; set; }

    public string? GunlukCalismaSuresi { get; set; }

    public string? FireOrani { get; set; }

    public string? CalismaSaatleri { get; set; }

    public DateTime? SonKullanimTarihi { get; set; }

    public decimal? SatinAlmaDegeri { get; set; }

    public decimal? HurdaDegeri { get; set; }

    public short? DemirbasKullanimOmru { get; set; }

    public string? AmortismanDonemi { get; set; }

    public string? AmortismanYontemi { get; set; }

    public bool? AmortismanKisitli { get; set; }

    public double? AmortismanOrani { get; set; }

    public decimal? SigortaDegeri { get; set; }

    public DateTime? PlanlananHurdaTarihi { get; set; }

    public DateTime? GerceklesenHurdaTarihi { get; set; }

    public bool? GarantiKapsami { get; set; }

    public string? GarantiSuresi { get; set; }

    public DateTime? GarantiBaslangicTarihi { get; set; }

    public DateTime? GarantiBitisTarihi { get; set; }

    public decimal? GunlukKullanimBedeli { get; set; }

    public long? SateklifSiparisTeslimatHareketiId { get; set; }

    public int? AlternatifEkipmanId { get; set; }

    public int? MusteriId { get; set; }

    public bool? MulkiyetId { get; set; }

    public string? CihazHassasiyeti { get; set; }

    public string? OlcmeAraligi { get; set; }

    public short? KalibrasyonPeriyodu { get; set; }

    public int? KalibrasyonFirmasiId { get; set; }

    public short? IsAkisSoruGrubuId { get; set; }

    public int? FydemirbasGirisMuhasebeHesabiId { get; set; }

    public int? FygiderMuhasebeHesabiId { get; set; }

    public int? FybirikmisAmortismanMuhasebeHesabiId { get; set; }

    public int? FydemirbasCikisMuhasebeHesabiId { get; set; }

    public int? FymasrafMerkeziId { get; set; }

    public bool? SenkronizeEdildi { get; set; }

    public DateTime? SenkronizasyonTarihi { get; set; }

    public string? SenkronizasyonAciklamasi { get; set; }

    public string? SenkronizasyonReferansi { get; set; }

    public int? EkleyenCalisanId { get; set; }

    public DateTime? EklemeTarihi { get; set; }

    public int? DuzenleyenCalisanId { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? SonErisenCalisanId { get; set; }

    public DateTime? SonErisim { get; set; }
}
