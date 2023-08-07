using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Kyuygunsuzluklar
{
    public string AdiSoyadi { get; set; } = null!;

    public string? KonumKodu { get; set; }

    public string Ad { get; set; } = null!;

    public string? SoruGrubuKodu { get; set; }

    public int? Onay { get; set; }

    public int IcTetkikPlaniId { get; set; }

    public DateTime? GerceklesenBaslamaTarihi { get; set; }

    public DateTime? GerceklesenBitisTarihi { get; set; }

    public string? Soru { get; set; }

    public string? Aciklama { get; set; }

    public string? Konu { get; set; }

    public string? InsanKaynaklariIkcalisanlar1AdiSoyadi { get; set; }

    public string? SistemAyarlariPGgorevDurumuAciklama { get; set; }
}
