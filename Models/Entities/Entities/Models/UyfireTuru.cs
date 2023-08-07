using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class UyfireTuru
{
    public int FireTuruId { get; set; }

    public string? FireKodu { get; set; }

    public string? FireTuruAdi { get; set; }

    public string? FireTuruKoduAdi { get; set; }

    public bool? IkinciKalite { get; set; }

    public bool? YenidenIsleme { get; set; }

    public virtual ICollection<KyuygunsuzUrunHizmet> KyuygunsuzUrunHizmets { get; set; } = new List<KyuygunsuzUrunHizmet>();

    public virtual ICollection<UyuretimVerileriArsivi> UyuretimVerileriArsivis { get; set; } = new List<UyuretimVerileriArsivi>();

    public virtual ICollection<UyuretimVerileri> UyuretimVerileris { get; set; } = new List<UyuretimVerileri>();

    public virtual ICollection<UyislemTuru> IslemTurus { get; set; } = new List<UyislemTuru>();
}
