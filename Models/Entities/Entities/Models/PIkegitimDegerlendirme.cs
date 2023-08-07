using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PIkegitimDegerlendirme
{
    public byte DegerlendirmeId { get; set; }

    public string? DegerlendirmeNotu { get; set; }

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesiEgitimOrtamiNavigations { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesiEgitimSuresiNavigations { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesiEgitimZamaniNavigations { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesiEgitiminIseOlanKatkisiNavigations { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesiEgitiminKisiyeOlanKatkisiNavigations { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesiEgitiminKonusuNavigations { get; set; } = new List<IkegitimKatilimciListesi>();

    public virtual ICollection<IkegitimKatilimciListesi> IkegitimKatilimciListesiEgitmeninKalitesiNavigations { get; set; } = new List<IkegitimKatilimciListesi>();
}
