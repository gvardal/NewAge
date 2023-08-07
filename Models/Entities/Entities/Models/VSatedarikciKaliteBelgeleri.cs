using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VSatedarikciKaliteBelgeleri
{
    public int Id { get; set; }

    public string? HesapKodu { get; set; }

    public string? FirmaAdi { get; set; }

    public string? HesapTuru { get; set; }

    public bool? Oncelikli { get; set; }

    public string? Etiketler { get; set; }

    public DateTime? BysaklamaSuresi { get; set; }

    public string? EvrakAdi { get; set; }

    public DateTime? DyyayinTarihi { get; set; }

    public short? KategoriId { get; set; }
}
