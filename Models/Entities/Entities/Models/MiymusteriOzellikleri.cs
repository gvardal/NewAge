using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiymusteriOzellikleri
{
    public long MusteriOzellikleriId { get; set; }

    public int? MiysahesapId { get; set; }

    public short? OzellikTuruId { get; set; }

    public short? KategoriId { get; set; }

    public string? Aciklama { get; set; }

    public string? Deger { get; set; }

    public virtual MiysahesapKategorileri? Kategori { get; set; }

    public virtual Miysahesaplar? Miysahesap { get; set; }

    public virtual PMiymusteriOzellikTuru? OzellikTuru { get; set; }
}
