using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VUretimPlaniIsEmriMalzemeIstekFisiDetayi
{
    public long UretimPlaniId { get; set; }

    public string? UretimPlaniUrunKodu { get; set; }

    public string UretimPlaniUrunAdi { get; set; } = null!;

    public decimal? ÜretimPlaniMiktar { get; set; }

    public decimal? ÜretimPlaniStokMiktari { get; set; }

    public DateTime UretimPlaniPlanlananBaslangicTarihi { get; set; }

    public DateTime? UretimPlaniPlanlananBitisTarihi { get; set; }

    public long IsEmriId { get; set; }

    public string? IsEmriUrunKodu { get; set; }

    public string IsEmriUrunAdi { get; set; } = null!;

    public decimal? IsEmriStokMiktari { get; set; }

    public DateTime IsEmriPlanlananPlanBaslangıçTarihi { get; set; }

    public DateTime? IsEmriPlanlananPlanBitisTarihi { get; set; }

    public long MalzemeIstekFisiId { get; set; }

    public string? MifkonumKoduAdi { get; set; }

    public DateTime? Miftarihi { get; set; }

    public bool? YevmiyeKaydi { get; set; }

    public DateTime? YevmiyeKaydiTarihi { get; set; }

    public long MalzemeIstekFisiDetayiId { get; set; }

    public string? MifdetayiUrunKodu { get; set; }

    public string MifdetayiUrunAdi { get; set; } = null!;

    public decimal? PlanlananMiktar { get; set; }

    public decimal? GerceklesenMiktar { get; set; }

    public string? MifdetayiKonumKoduAdi { get; set; }

    public bool? OtomatikTuketim { get; set; }
}
