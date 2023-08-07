using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class PpotansiyelMusteriTuru
{
    public byte Id { get; set; }

    public string? PotansiyelMusteriTuru { get; set; }

    public string? Aciklama { get; set; }

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();
}
