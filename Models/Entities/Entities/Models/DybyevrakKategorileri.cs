using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class DybyevrakKategorileri
{
    public short KategoriId { get; set; }

    public short? UstKategoriId { get; set; }

    public string? KategoriKodu { get; set; }

    public string? KategoriAdi { get; set; }

    /// <summary>
    /// Dokuman True, Belge False
    /// </summary>
    public bool? DokumanBelge { get; set; }

    public int? BelgeSayisi { get; set; }

    public DateTime? SonBelgeDuzenlemeTarihi { get; set; }

    public int? SonBelgeDuzenleyenId { get; set; }

    public short? SaklamaSuresi { get; set; }

    public virtual ICollection<Dybyevraklar> Dybyevraklars { get; set; } = new List<Dybyevraklar>();

    public virtual ICollection<DybyevrakKategorileri> InverseUstKategori { get; set; } = new List<DybyevrakKategorileri>();

    public virtual Ikcalisanlar? SonBelgeDuzenleyen { get; set; }

    public virtual DybyevrakKategorileri? UstKategori { get; set; }
}
