using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUyuretimPlaniIsEmriRotasiIsciZamanKarti
{
    public long IsciZamanKartiId { get; set; }

    public int IsEmriRotaId { get; set; }

    public string? OperasyonuKodu { get; set; }

    public byte? Sira { get; set; }

    public int IsEmriRotasiKonumId { get; set; }

    public string? IsEmriRotasiKonumKodu { get; set; }

    public string IsEmriRotasiKonumAd { get; set; } = null!;

    public string? KonumKoduAdi { get; set; }

    public long IsEmriId { get; set; }

    public DateTime IsEmriBaslangicTarihi { get; set; }

    public DateTime? IsEmriBitisTarihi { get; set; }

    public DateTime? IsEmriGercBaslamaTarihi { get; set; }

    public DateTime? IsEmriGercBitisTarihi { get; set; }

    public int IsEmriUrunId { get; set; }

    public string? IsEmriUrunKodu { get; set; }

    public string? IsEmriUrunAdi { get; set; }

    public string IsEmriUrunKoduAdi { get; set; } = null!;

    public long UretimPlaniId { get; set; }

    public int? ProjeId { get; set; }

    public int? SiparisId { get; set; }

    public decimal? UretimMiktari { get; set; }

    public decimal? StokMiktari { get; set; }

    public decimal? FireMiktari { get; set; }

    public DateTime PlanlananBaslamaTarihi { get; set; }

    public DateTime? PlanlananBitimTarihi { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitimTarihi { get; set; }

    public string? UretimPlaniAciklama { get; set; }

    public int UretimPlaniUrunId { get; set; }

    public string? UretimPlaniUrunKodu { get; set; }

    public string? UretimPlaniUrunAdi { get; set; }

    public string UretimPlaniUrunKoduAdi { get; set; } = null!;

    public short IslemTuruId { get; set; }

    public string? IslemTuruKodu { get; set; }

    public string IslemTuruAdi { get; set; } = null!;

    public DateTime? IsEmriRotasiPlanBaslama { get; set; }

    public DateTime? IsEmriRotasiPlanBiltis { get; set; }

    public decimal? IsEmriRotasiPlanlananGirdi { get; set; }

    public int RotaCalisanId { get; set; }

    public string RotaCalisanAdiSoyadi { get; set; } = null!;

    public bool? UretimDurus { get; set; }

    public byte? DurusTuruId { get; set; }

    public DateTime? BaslamaSaati { get; set; }

    public DateTime? BitisSaati { get; set; }

    public decimal? CalisilanZaman { get; set; }

    public bool? Tamamlandi { get; set; }

    public string? IsciZamanKartiAciklama { get; set; }
}
