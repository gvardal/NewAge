using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSysiparisDetayiUrunOpsiyonlari
{
    public long? UrunOzellikleriId { get; set; }

    public string? Deger { get; set; }

    public long? SiparisDetayiId { get; set; }

    public string? Aciklama { get; set; }

    public long SiparisUrunOzellikleriOpsiyonId { get; set; }

    public string? UrunKoduAdi { get; set; }

    public string? OzellikTuru { get; set; }

    public bool? RapordaGosterme { get; set; }
}
