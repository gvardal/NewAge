using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimRotaTakip
{
    public int? IsEmriRotaId { get; set; }

    public long? IsEmriId { get; set; }

    public long? UretimPlaniId { get; set; }

    public int? SiparisId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public int? OncekiIsEmriRotaId { get; set; }

    public long? UstIsEmriId { get; set; }

    public string? OperasyonuKodu { get; set; }

    public string? IsEmriKodu { get; set; }

    public string? Ad { get; set; }

    public string? Adi { get; set; }

    public string? UrunKodu { get; set; }

    public string? UrunKoduAdi { get; set; }

    public decimal? UretimMiktari { get; set; }

    public string? Durum { get; set; }

    public string? FirmaAdi { get; set; }

    public int? CalisanId { get; set; }

    public short? IslemTuruId { get; set; }

    public int? KonumId { get; set; }

    public byte? RotaDurumu { get; set; }

    public byte? Sira { get; set; }

    public string? UretimPlaniAciklama { get; set; }

    public string? Aciklama { get; set; }

    public int? LotBuyuklugu { get; set; }

    public decimal? PlanlananGirdi { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public float? PlanlananTamamlanmaZamani { get; set; }

    public float? HazirlamaSuresi { get; set; }

    public float? IslemSuresi { get; set; }

    public float? StandartSure { get; set; }

    public float? Mesafe { get; set; }

    public decimal? OrtalamaCevrimSuresi { get; set; }

    public decimal? GerceklesenCikti { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public decimal? GerceklesenTamamlanmaZamani { get; set; }

    public bool? Tamamlandi { get; set; }

    public DateTime? DuzenlemeTarihi { get; set; }

    public int? UrunKategorisiId { get; set; }

    public short? Fire { get; set; }

    public string? HazirlikDurum { get; set; }

    public string? OlcuBirimi { get; set; }

    public int? UrunId { get; set; }

    public int? MusteriKoduId { get; set; }

    public int? IsEmriEkleyenId { get; set; }

    public string? KonumKoduAdi { get; set; }

    public string? KonumAdi { get; set; }

    public string? UstKonumAdi { get; set; }

    public decimal? Agirlik { get; set; }

    public short? GozSayisi { get; set; }

    public decimal? SonVardiyaMiktari { get; set; }

    public int? KutuNo { get; set; }

    public short? PaletNo { get; set; }

    public long? EnvanterId { get; set; }
}
