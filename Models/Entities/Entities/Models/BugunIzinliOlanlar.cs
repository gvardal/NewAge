using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class BugunIzinliOlanlar
{
    public int Id { get; set; }

    public string AdiSoyadi { get; set; } = null!;

    public string? Birimi { get; set; }

    public string? Unvani { get; set; }

    public string? CalismaGrubu { get; set; }

    public bool? Onay { get; set; }

    public DateTime? BaslangicTarihi { get; set; }

    public DateTime? BitisTarihi { get; set; }

    public long BordroIzinId { get; set; }
}
