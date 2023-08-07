using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSevkEdilmisUrunOzellik
{
    public string? FirmaAdi { get; set; }

    public DateTime? FaturaTarihi { get; set; }

    public decimal? Miktari { get; set; }

    public long FaturaId { get; set; }

    public int SiparisId { get; set; }

    public string? UrunKodu { get; set; }

    public string? Adi { get; set; }

    public short? OzellikTuruId { get; set; }

    public string? Aciklama { get; set; }

    public string? Deger { get; set; }

    public byte? IslemTuruId { get; set; }
}
