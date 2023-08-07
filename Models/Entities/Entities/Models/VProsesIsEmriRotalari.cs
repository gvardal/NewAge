using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VProsesIsEmriRotalari
{
    public long? IsEmriId { get; set; }

    public int? SiparisNo { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? UretimPlaniId { get; set; }

    public int IsEmriRotaId { get; set; }

    public string? OperasyonuKodu { get; set; }

    public string? Ad { get; set; }

    public string? Adi { get; set; }

    public string? UrunKodu { get; set; }

    public string? UrunKoduAdi { get; set; }

    public DateTime? PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitisTarihi { get; set; }

    public decimal? UretimMiktari { get; set; }

    public float? PlanlananTamamlanmaZamani { get; set; }

    public string? Aciklama { get; set; }

    public DateTime? TerminTarihi { get; set; }

    public string? KonumAd { get; set; }

    public int? KonumId { get; set; }

    public byte? IsEmriDurumId { get; set; }

    public byte? IsEmriRotaDurumuId { get; set; }

    public string? Durum { get; set; }

    public decimal? StokMiktari { get; set; }

    public decimal? FireMiktari { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public decimal? GerceklesenTamamlanmaZamani { get; set; }

    public int? OncekIsEmriRotaId { get; set; }

    public int? UrunId { get; set; }

    public short? IslemTuruId { get; set; }

    public decimal? PlanlananGirdi { get; set; }

    public decimal? GerceklesenCikti { get; set; }

    public short? Fire { get; set; }

    public byte? Sira { get; set; }

    public bool? OtomatikDurus { get; set; }

    public short? GozSayisi { get; set; }

    public decimal? LotBuyuklugu { get; set; }

    public decimal? TamamlanmaOrani { get; set; }

    public long? KesimIsEmriId { get; set; }

    public byte? KonumTuruId { get; set; }

    public int? SecenId { get; set; }

    public bool? Secili { get; set; }

    public bool? KesimIslemi { get; set; }

    public float? StandartSure { get; set; }

    public decimal? NetAgirlik { get; set; }

    public bool? Tamamlandi { get; set; }
}
