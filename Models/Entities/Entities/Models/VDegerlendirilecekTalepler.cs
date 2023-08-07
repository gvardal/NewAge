using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class VDegerlendirilecekTalepler
{
    public long? TeklifSiparisDetayiId { get; set; }

    public int? TeklifSiparisId { get; set; }

    public long? GenelTalepId { get; set; }

    public int? MalzemeUrunAdi { get; set; }

    public byte? DurumId { get; set; }

    public decimal? Miktar { get; set; }

    public string? TeklifSiparisTuru { get; set; }

    public bool? TeklifOnayi { get; set; }

    public string? UrunAdi { get; set; }

    public string? UrunKategorisi { get; set; }

    public string? TalepDurumu { get; set; }
}
