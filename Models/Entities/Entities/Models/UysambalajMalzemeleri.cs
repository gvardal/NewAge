using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UysambalajMalzemeleri
{
    public int AmbalajMalzemeId { get; set; }

    public int? UstAmbalajMalzemeId { get; set; }

    public string? RevizyonKodu { get; set; }

    public int? KategoriId { get; set; }

    public int? MalzemeId { get; set; }

    public int? UrunId { get; set; }

    public byte? AmbalajTuru { get; set; }

    public string? OzelGrupKodu { get; set; }

    public string? UrunTanimi { get; set; }

    public string? Pazar { get; set; }

    public string? Segment { get; set; }

    public string? Marka { get; set; }

    public string? RafOmru { get; set; }

    public byte? DurumId { get; set; }

    public short? SurecId { get; set; }

    public virtual Uyurunler AmbalajMalzeme { get; set; } = null!;

    public virtual UyurunKategorisi? Kategori { get; set; }

    public virtual Uyurunler? Malzeme { get; set; }

    public virtual ICollection<UysambalajBilgisi> UysambalajBilgisis { get; set; } = new List<UysambalajBilgisi>();

    public virtual ICollection<UysbaskiBilgisi> UysbaskiBilgisis { get; set; } = new List<UysbaskiBilgisi>();

    public virtual ICollection<UysgrafikTasarim> UysgrafikTasarims { get; set; } = new List<UysgrafikTasarim>();
}
