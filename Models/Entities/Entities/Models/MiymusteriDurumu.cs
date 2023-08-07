using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class MiymusteriDurumu
{
    public string MusteriDurumuId { get; set; } = null!;

    public string? MusteriDurumu { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();
}
