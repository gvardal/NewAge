using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class SysiparisUrunOzellikOpsiyonlari
{
    public long SiparisUrunOzellikleriOpsiyonId { get; set; }

    public long? SiparisDetayiId { get; set; }

    public long? UrunOzellikleriId { get; set; }

    public string? Deger { get; set; }

    public string? Aciklama { get; set; }

    public virtual SysiparisDetayi? SiparisDetayi { get; set; }

    public virtual UyurunOzellikleri? UrunOzellikleri { get; set; }
}
