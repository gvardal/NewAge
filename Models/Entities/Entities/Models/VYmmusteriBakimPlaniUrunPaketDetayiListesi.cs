using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VYmmusteriBakimPlaniUrunPaketDetayiListesi
{
    public int? SiparisId { get; set; }

    public string? Konu { get; set; }

    public short? SiraNo { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? SevkiyatPlaniId { get; set; }

    public short? TeslimatPlaniSiraNo { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? PaketlenmisMiktar { get; set; }

    public decimal? PakettekiMiktar { get; set; }

    public long? PaketlemeId { get; set; }

    public int? UrunId { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public string? UrunKoduAdi { get; set; }

    public string? KutuNo { get; set; }
}
