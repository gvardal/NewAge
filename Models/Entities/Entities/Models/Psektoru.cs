using System;
using System.Collections.Generic;

namespace Entities.Models;

public partial class Psektoru
{
    public short Id { get; set; }

    public string? Kodu { get; set; }

    public string? Sektoru { get; set; }

    public virtual ICollection<IkisDeneyimleri> IkisDeneyimleris { get; set; } = new List<IkisDeneyimleri>();

    public virtual ICollection<Miysahesaplar> Miysahesaplars { get; set; } = new List<Miysahesaplar>();
}
